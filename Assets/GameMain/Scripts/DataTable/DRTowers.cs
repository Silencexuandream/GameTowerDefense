using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace GameTowerDefense
{
    /// <summary>
    /// 炮塔。
    /// </summary>
    public class DRTowers : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取炮塔编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取资源名字。
        /// </summary>
        public string AssetsName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取实体组。
        /// </summary>
        public string EntityGroup
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取最大生命。
        /// </summary>
        public int HP
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击力。
        /// </summary>
        public int Attack
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取速度。
        /// </summary>
        public float Speed
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取死亡特效编号。
        /// </summary>
        public int DeadEffectId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取死亡声音编号。
        /// </summary>
        public int DeadSoundId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取逻辑脚本。
        /// </summary>
        public string EntityLogic
        {
            get;
            private set;
        }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnStrings.Length; i++)
            {
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
            index++;
            AssetsName = columnStrings[index++];
            EntityGroup = columnStrings[index++];
            HP = int.Parse(columnStrings[index++]);
            Attack = int.Parse(columnStrings[index++]);
            Speed = float.Parse(columnStrings[index++]);
            DeadEffectId = int.Parse(columnStrings[index++]);
            DeadSoundId = int.Parse(columnStrings[index++]);
            EntityLogic = columnStrings[index++];

            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
                    AssetsName = binaryReader.ReadString();
                    EntityGroup = binaryReader.ReadString();
                    HP = binaryReader.Read7BitEncodedInt32();
                    Attack = binaryReader.Read7BitEncodedInt32();
                    Speed = binaryReader.ReadSingle();
                    DeadEffectId = binaryReader.Read7BitEncodedInt32();
                    DeadSoundId = binaryReader.Read7BitEncodedInt32();
                    EntityLogic = binaryReader.ReadString();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private void GeneratePropertyArray()
        {

        }
    }
}
