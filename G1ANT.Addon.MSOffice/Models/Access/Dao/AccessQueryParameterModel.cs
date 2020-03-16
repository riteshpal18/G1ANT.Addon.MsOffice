﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.MSOffice
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using Microsoft.Office.Interop.Access.Dao;

namespace G1ANT.Addon.MSOffice.Models.Access.Dao
{
    public class AccessQueryParameterModel
    {
        public string Name { get; }
        public dynamic Value { get; }
        public AccessQueryPropertyCollectionModel Properties { get; }
        public string Type { get; }

        public AccessQueryParameterModel(Parameter parameter)
        {
            Name = parameter.Name;
            Value = parameter.Value;
            Properties = new AccessQueryPropertyCollectionModel(parameter.Properties);
            Type = ((DataTypeEnum)parameter.Type).ToString();
        }
    }
}
