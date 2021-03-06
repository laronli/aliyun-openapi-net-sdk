/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class CreateInboundOrderRequest : RpcAcsRequest<CreateInboundOrderResponse>
    {
        public CreateInboundOrderRequest()
            : base("digitalstore", "2020-01-07", "CreateInboundOrder", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string clientToken;

		private string toWarehouseId;

		private string orderCode;

		private string fromBusinessUnitId;

		private string fromWarehouseId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string ToWarehouseId
		{
			get
			{
				return toWarehouseId;
			}
			set	
			{
				toWarehouseId = value;
				DictionaryUtil.Add(BodyParameters, "ToWarehouseId", value);
			}
		}

		public string OrderCode
		{
			get
			{
				return orderCode;
			}
			set	
			{
				orderCode = value;
				DictionaryUtil.Add(BodyParameters, "OrderCode", value);
			}
		}

		public string FromBusinessUnitId
		{
			get
			{
				return fromBusinessUnitId;
			}
			set	
			{
				fromBusinessUnitId = value;
				DictionaryUtil.Add(BodyParameters, "FromBusinessUnitId", value);
			}
		}

		public string FromWarehouseId
		{
			get
			{
				return fromWarehouseId;
			}
			set	
			{
				fromWarehouseId = value;
				DictionaryUtil.Add(BodyParameters, "FromWarehouseId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateInboundOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInboundOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
