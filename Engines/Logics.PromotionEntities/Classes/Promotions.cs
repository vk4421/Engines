﻿using System;
using System.Runtime.Serialization;

namespace Logics.PromotionEntities.Classes
{
    [Serializable]
    public class ActivePromotion
    {
        [DataMember]
        public long SkuId { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }

        [DataMember]
        public decimal FinalPrice { get; set; }
    }
}
