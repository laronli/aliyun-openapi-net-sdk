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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeDomainBasicConfigsResponseUnmarshaller
    {
        public static DescribeDomainBasicConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainBasicConfigsResponse describeDomainBasicConfigsResponse = new DescribeDomainBasicConfigsResponse();

			describeDomainBasicConfigsResponse.HttpResponse = context.HttpResponse;
			describeDomainBasicConfigsResponse.RequestId = context.StringValue("DescribeDomainBasicConfigs.RequestId");
			describeDomainBasicConfigsResponse.TotalCount = context.IntegerValue("DescribeDomainBasicConfigs.TotalCount");

			List<DescribeDomainBasicConfigsResponse.DescribeDomainBasicConfigs_DomainConfig> describeDomainBasicConfigsResponse_domainConfigs = new List<DescribeDomainBasicConfigsResponse.DescribeDomainBasicConfigs_DomainConfig>();
			for (int i = 0; i < context.Length("DescribeDomainBasicConfigs.DomainConfigs.Length"); i++) {
				DescribeDomainBasicConfigsResponse.DescribeDomainBasicConfigs_DomainConfig domainConfig = new DescribeDomainBasicConfigsResponse.DescribeDomainBasicConfigs_DomainConfig();
				domainConfig.Owner = context.StringValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].Owner");
				domainConfig.WafStatus = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].WafStatus");
				domainConfig.CcStatus = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].CcStatus");
				domainConfig.CcMode = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].CcMode");
				domainConfig.AclStatus = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].AclStatus");
				domainConfig.WafMode = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].WafMode");
				domainConfig.Version = context.LongValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].Version");
				domainConfig.Domain = context.StringValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].Domain");
				domainConfig.Status = context.IntegerValue("DescribeDomainBasicConfigs.DomainConfigs["+ i +"].Status");

				describeDomainBasicConfigsResponse_domainConfigs.Add(domainConfig);
			}
			describeDomainBasicConfigsResponse.DomainConfigs = describeDomainBasicConfigsResponse_domainConfigs;
        
			return describeDomainBasicConfigsResponse;
        }
    }
}
