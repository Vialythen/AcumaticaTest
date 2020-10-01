using PX.Data;
using PX.SM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Objects.WZ
{
    public class PXScenarioToSiteMapAddHelper : PXFieldScreenToSiteMapAddHelper<WZScenario>
    {
        public PXScenarioToSiteMapAddHelper(PXGraph graph, string screenIdPrefix, string urlPrefix, Type nameField, Type titleField, Type screenIDField, Type visibleField, params Field[][] fieldSets)
            : base(graph, screenIdPrefix, urlPrefix, nameField, titleField, screenIDField, visibleField, fieldSets)
        { }

		protected override void SiteMap_InsertedRowPersisting(PXCache sender, SiteMap row)
		{
            if (string.IsNullOrEmpty(row.Url))
                base.SiteMap_InsertedRowPersisting(sender, row);
            else
                sender.SetValue<SiteMap.screenID>(row, GenerateNewScreenID(row));
		}

        protected override void T_SitemapTitle_FieldUpdated(PXCache sender, PXFieldUpdatedEventArgs e)
        {
            if (e.Row != null)
            {
                string title = (string)sender.GetValue(e.Row, TitleField);

                PXSiteMapNode existingNode = FindNodes((WZScenario)e.Row).FirstOrDefault();
                SiteMapInternal record = null;
                if (existingNode != null)
                {
                    record = (SiteMapInternal)SiteMap.SelectSingle(existingNode.NodeID);
                }

                string url = existingNode != null && existingNode.Url != null ? existingNode.Url : BuildUrl((WZScenario)e.Row);
                foreach (SiteMapInternal inserted in SiteMapCache.Inserted)
                {
                    if (string.Equals(inserted.Url, url, StringComparison.OrdinalIgnoreCase))
                        SiteMapCache.Delete(inserted);
                }

                if (record == null)
                {
                    record = (SiteMapInternal)SiteMapCache.Insert();
                }
                if (record != null)
                {
                    record.Url = url;
                    record.ParentID = PXSiteMap.RootNode.NodeID;
                    record.Title = (string)sender.GetValue(e.Row, TitleField);
                    record = (SiteMapInternal)SiteMapCache.Update(record);
                    if (ScreenIDField != null)
                    {
                        sender.SetValue(e.Row, ScreenIDField, IsScreenFieldGuid ? (object)record.NodeID : record.ScreenID);
                    }
                }
            }
        }
    }
}
