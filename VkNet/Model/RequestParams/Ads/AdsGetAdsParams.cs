using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VkNet.Enums.Filters;
using VkNet.Utils;

namespace VkNet.Model.RequestParams
{
	/// <summary>
	/// Параметры метода wall.search
	/// </summary>
	[Serializable]
	public class AdsGetAdsParams
    {
        /// <summary>
        /// Идентификатор рекламного кабинета.
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Доступно и обязательно для рекламных агентств. Идентификатор клиента, у которого запрашиваются рекламные объявления. 
        /// </summary>
        [JsonProperty("client_id")]
        public long? ClientId { get; set; }

        /// <summary>
        /// Флаг, задающий необходимость вывода архивных объявлений. 0 — выводить только активные объявления; 1 — выводить все объявления.
        /// </summary>
        [JsonProperty("include_deleted")]
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// Фильтр по рекламным кампаниям. 
        /// Сериализованный JSON-массив, содержащий id кампаний.Если параметр равен null, то будут выводиться рекламные объявления всех кампаний.
        /// </summary>
        [JsonProperty("campaign_ids")]
        public IEnumerable<long> CampaignIds { get; set; }

        /// <summary>
        /// Фильтр по рекламным объявлениям. 
        /// Сериализованный JSON-массив, содержащий id объявлений.Если параметр равен null, то будут выводиться все рекламные объявления.
        /// </summary>
        [JsonProperty("ad_ids")]
        public IEnumerable<long> AdIds { get; set; }

        /// <summary>
        /// Ограничение на количество возвращаемых объявлений. 
        /// Используется, только если параметр ad_ids равен null, а параметр campaign_ids содержит id только одной кампании. 
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Cмещение. Используется в тех же случаях, что и параметр limit. 
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// Привести к типу VkParameters.
        /// </summary>
        /// <param name="p">Параметры.</param>
        /// <returns></returns>
        public static VkParameters ToVkParameters(AdsGetAdsParams p)
		{
			var parameters = new VkParameters
			{
				{ "account_id", p.AccountId },
				{ "client_id", p.ClientId },
				{ "include_deleted", p.IncludeDeleted },
				{ "campaign_ids", p.CampaignIds != null ? "[" + string.Join(",", p.CampaignIds) + "]" : null },
                { "ad_ids", p.AdIds != null ? "[" + string.Join(",", p.AdIds) + "]" : null },
                { "limit", p.Limit },
                { "offset", p.Offset }

            };

			return parameters;
		}
	}
}