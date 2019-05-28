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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancesByPerformanceResponseUnmarshaller
    {
        public static DescribeDBInstancesByPerformanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesByPerformanceResponse describeDBInstancesByPerformanceResponse = new DescribeDBInstancesByPerformanceResponse();

			describeDBInstancesByPerformanceResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesByPerformanceResponse.RequestId = context.StringValue("DescribeDBInstancesByPerformance.RequestId");
			describeDBInstancesByPerformanceResponse.PageNumber = context.IntegerValue("DescribeDBInstancesByPerformance.PageNumber");
			describeDBInstancesByPerformanceResponse.TotalRecordCount = context.IntegerValue("DescribeDBInstancesByPerformance.TotalRecordCount");
			describeDBInstancesByPerformanceResponse.PageRecordCount = context.IntegerValue("DescribeDBInstancesByPerformance.PageRecordCount");

			List<DescribeDBInstancesByPerformanceResponse.DescribeDBInstancesByPerformance_DBInstancePerformance> describeDBInstancesByPerformanceResponse_items = new List<DescribeDBInstancesByPerformanceResponse.DescribeDBInstancesByPerformance_DBInstancePerformance>();
			for (int i = 0; i < context.Length("DescribeDBInstancesByPerformance.Items.Length"); i++) {
				DescribeDBInstancesByPerformanceResponse.DescribeDBInstancesByPerformance_DBInstancePerformance dBInstancePerformance = new DescribeDBInstancesByPerformanceResponse.DescribeDBInstancesByPerformance_DBInstancePerformance();
				dBInstancePerformance.CPUUsage = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].CPUUsage");
				dBInstancePerformance.IOPSUsage = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].IOPSUsage");
				dBInstancePerformance.DiskUsage = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].DiskUsage");
				dBInstancePerformance.SessionUsage = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].SessionUsage");
				dBInstancePerformance.DBInstanceId = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].DBInstanceId");
				dBInstancePerformance.DBInstanceDescription = context.StringValue("DescribeDBInstancesByPerformance.Items["+ i +"].DBInstanceDescription");

				describeDBInstancesByPerformanceResponse_items.Add(dBInstancePerformance);
			}
			describeDBInstancesByPerformanceResponse.Items = describeDBInstancesByPerformanceResponse_items;
        
			return describeDBInstancesByPerformanceResponse;
        }
    }
}
