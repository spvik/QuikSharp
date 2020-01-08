// Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
using Newtonsoft.Json;

namespace QuikSharp.DataStructures
{
    /// <summary>
    /// ������ �� �������� ���������
    /// </summary>
    public class MoneyLimitEx
    {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// ��� ������
        /// </summary>
        [JsonProperty("currcode")]
        public string CurrCode { get; set; }

        /// <summary>
        /// ��� ��������
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// ������������� �����
        /// </summary>
        [JsonProperty("firmid")]
        public string FirmId { get; set; }

        /// <summary>
        /// ��� �������
        /// </summary>
        [JsonProperty("client_code")]
        public string ClientCode { get; set; }

        /// <summary>
        /// �������� ������� �� �������
        /// </summary>
        [JsonProperty("openbal")]
        public double OpenBal { get; set; }

        /// <summary>
        /// �������� ����� �� �������
        /// </summary>
        [JsonProperty("openlimit")]
        public double OpenLimit { get; set; }

        /// <summary>
        /// ������� ������� �� �������
        /// </summary>
        [JsonProperty("currentbal")]
        public double CurrentBal { get; set; }

        /// <summary>
        /// ������� ����� �� �������
        /// </summary>
        [JsonProperty("currentlimit")]
        public double CurrentLimit { get; set; }

        /// <summary>
        /// ��������������� ����������
        /// </summary>
        [JsonProperty("locked")]
        public double Locked { get; set; }

        /// <summary>
        /// ��������� ������� � ������� �� ������� �������������� �����
        /// </summary>
        [JsonProperty("locked_value_coef")]
        public double LockedValueCoef { get; set; }

        /// <summary>
        /// ��������� ������� � ������� �� ������� ������������ �����
        /// </summary>
        [JsonProperty("locked_margin_value")]
        public double LockedMarginValue { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        [JsonProperty("leverage")]
        public double Leverage { get; set; }

        /// <summary>
        /// ��� ������. ��������� ��������:
        /// �0� � ������� ������,
        /// ����� � ��������������� ������
        /// </summary>
        [JsonProperty("limit_kind")]
        public int LimitKind { get; set; }

        /// <summary>
        /// ���������������� ���� ������������ �������
        /// </summary>
        [JsonProperty("wa_position_price")]
        public double WaPositionPrice { get; set; }

        /// <summary>
        /// ����������� ����������� ������
        /// </summary>
        [JsonProperty("orders_collateral")]
        public double OrdersCollateral { get; set; }

        /// <summary>
        /// ����������� ����������� �������
        /// </summary>
        [JsonProperty("positions_collateral")]
        public double PositionsCollateral { get; set; }

        // ReSharper restore InconsistentNaming
    }
}