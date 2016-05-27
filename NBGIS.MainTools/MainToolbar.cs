using System;
using System.Collections.Generic;
using System.Text;
using NBGIS.PluginEngine;

namespace NBGIS.MainTools
{
    public class MainToolbar : NBGIS.PluginEngine.IToolBarDef
    {
        #region IToolBarDef ≥…‘±

        public string Caption
        {
            get { return "MainTools"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "NBGIS.MainTools.cAddData";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "NBGIS.MainTools.cZoomIn";
                    itemDef.Group = true;
                    break;
                case 2:
                    itemDef.ID = "NBGIS.MainTools.cZoomOut";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "NBGIS.MainTools.cPan";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "NBGIS.MainTools.cIdentify";
                    itemDef.Group = false;
                    break;
                case 5:
                    itemDef.ID = "NBGIS.MainTools.cFullExtent";
                    itemDef.Group = true;
                    break;
                case 6:
                    itemDef.ID = "NBGIS.MainTools.cRefreshView";
                    itemDef.Group = false;
                    break;
                case 7:
                    //itemDef.ID = "NBGIS.MainTools.cIdentify";
                    //itemDef.Group = true;
                    break;
                default:
                    break;

            }
        }

        public long ItemCount
        {
            get { return 7; }
        }

        public string Name
        {
            get { return "MainTools"; }
        }

        #endregion
    }
}
