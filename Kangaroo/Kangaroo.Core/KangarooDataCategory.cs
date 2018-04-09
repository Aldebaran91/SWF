﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kangaroo.Core
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class KangarooDataCategory
    {
        /// <summary>
        /// 
        /// </summary>
        public static KangarooDataCategory Debug = new KangarooDataCategory(0, "Debug");
        /// <summary>
        /// 
        /// </summary>
        public static KangarooDataCategory Info = new KangarooDataCategory(1, "Info");
        /// <summary>
        /// 
        /// </summary>
        public static KangarooDataCategory Warning = new KangarooDataCategory(2, "Warning");
        /// <summary>
        /// 
        /// </summary>
        public static KangarooDataCategory Error = new KangarooDataCategory(3, "Error");
        /// <summary>
        /// 
        /// </summary>
        public static KangarooDataCategory Fatal = new KangarooDataCategory(4, "Fatal");

        /// <summary>
        /// 
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="label"></param>
        private KangarooDataCategory(int level, string label)
        {
            this.Level = level;
            this.Label = label;
        }
    }
}
