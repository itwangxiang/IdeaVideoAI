﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaVideoAI
{
    public class Config
    {

        private static readonly Lazy<Config> lazy =
           new Lazy<Config>(() => new Config());

        public static Config Instance { get { return lazy.Value; } }

        private Config() {

            // 加图
            tab3BgVideoFiles = new List<string>();
            tab3ExecCount = 1;

            //加边框
            tab4FrameFile = new List<string>();

        }

        /// 
        /// 加图
        /// 

        public int tab3ExecCount;
        public int tab3MinStartTime;
        public int tab3MaxStartTime;
        public int tab3OutTime;
        public bool tab3PictureSharpen;
        public bool tab3PictureWidthMax;

        //logo 图
        public List<String> tab3LogoPictureFile;
        public string getRandomByTab3LogoPicture()
        {
            return tab3LogoPictureFile[new Random().Next(tab3LogoPictureFile.Count())];
        }

        //背景视频
        public List<String> tab3BgVideoFiles;
        public string getRandomByTab3BackgroundVideo()
        {
            return tab3BgVideoFiles[new Random().Next(tab3BgVideoFiles.Count())];
        }

        ///
        /// 加边框
        /// 


        //logo 图
        public List<String> tab4FrameFile;
        public string getRandomByTab4Frame()
        {
            return tab4FrameFile[new Random().Next(tab4FrameFile.Count())];
        }

    }
}
