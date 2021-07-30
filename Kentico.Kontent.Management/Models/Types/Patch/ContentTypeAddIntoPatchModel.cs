﻿using Kentico.Kontent.Management.Models.Items.Identifiers;
using Newtonsoft.Json;

namespace Kentico.Kontent.Management.Models.Types.Patch
{
    public class ContentTypeAddIntoPatchModel : ContentTypeOperationBaseModel
    {
        public override string Op => "addInto";

        [JsonProperty("value")]
        public dynamic Value { get; set; }

        [JsonProperty("before")]
        public Identifier Before { get; set; }

        [JsonProperty("after")]
        public Identifier After { get; set; }
    }
}
