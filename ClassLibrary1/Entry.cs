using Mes.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Entry : Mes.Core.Interface.IMesPlugin
    {
        #region IMesPlugin 成员
        IApplication _application = null;
        public string PluginName
        {
            get { return "订单完成率"; }
        }

        public string PluginDescription
        {
            get { return " 订单完成率"; }
        }

        public string PluginAuthor
        {
            get { return "pengbo.du"; }
        }

        public IApplication Application
        {
            get
            {
                return _application;
            }
            set
            {
                _application = value;
            }
        }

        public void Load()
        {

            MainForm mainForm = new MainForm();
            Mes.ControlsEx.Utility.FormHelper.Show(mainForm, _application);
            //mainForm.ShowDialog();

        }

        public void UnLoad()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
