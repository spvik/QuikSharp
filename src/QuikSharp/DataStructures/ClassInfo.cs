// Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
using Newtonsoft.Json;

namespace QuikSharp.DataStructures
{
    /// <summary>
    /// �������� ������
    /// </summary>
    public class ClassInfo
    {
        // ReSharper disable InconsistentNaming

        /// <summary>
        /// ��� �����
        /// </summary>
        [JsonProperty("firmid")]
        public string FirmId { get; set; }

        /// <summary>
        /// ������������ ������
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ��� ������
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// ���������� ���������� � ������
        /// </summary>
        [JsonProperty("npars")]
        public int NPars { get; set; }

        /// <summary>
        /// ���������� ����� � ������
        /// </summary>
        [JsonProperty("nsecs")]
        public int NSecs { get; set; }

        // ReSharper restore InconsistentNaming

        public override string ToString()
        {
            return this.ToJson();
        }
    }
}