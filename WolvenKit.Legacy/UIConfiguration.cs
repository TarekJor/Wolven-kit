﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W.Types;

namespace WolvenKit
{
    public class UIConfiguration
    {
        public static string ConfigurationPath
        {
            get
            {
                var path = Application.ExecutablePath;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_uiconfig.xml");
            }
        }

        

        /// <summary>
        ///     Configuration values
        /// </summary>
        
        public Size MainSize { get; set; }
        public Point MainLocation { get; set; }
        public FormWindowState MainState { get; set; }
        public EColorThemes ColorTheme { get; set; }

        public List<int> CustomHighlightColor { get; set; }

        ~UIConfiguration()
        {
            Save();
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof (UIConfiguration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static UIConfiguration Load()
        {
            if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
            {
                var ser = new XmlSerializer(typeof (UIConfiguration));
                var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                var config = (UIConfiguration) ser.Deserialize(stream);
                stream.Close();

                // hack for new vars
                if (config.CustomHighlightColor == null || config.CustomHighlightColor.Count < 3)
                    config.CustomHighlightColor = new List<int> { Color.BlueViolet.ToArgb(), SystemColors.MenuHighlight.ToArgb(), Color.BlueViolet.ToArgb() };

                return config;
            }

            // Defaults
            return new UIConfiguration
            {
                ColorTheme = EColorThemes.VS2015Light,
                CustomHighlightColor = new List<int> { Color.BlueViolet.ToArgb(), Color.LightSeaGreen.ToArgb(), Color.BlueViolet.ToArgb() }
            };
        }
    }
}