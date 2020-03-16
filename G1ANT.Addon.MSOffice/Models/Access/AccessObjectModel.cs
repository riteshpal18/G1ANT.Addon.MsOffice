﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.MSOffice
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using Microsoft.Office.Interop.Access;
using System;

namespace G1ANT.Addon.MSOffice.Models.Access
{
    public class AccessObjectModel : IComparable
    {
        public AccessObject Object { get; }
        public string Name { get; }
        public string FullName { get; }
        public bool IsLoaded { get; }
        public string Type { get; }
        public int Attributes { get; }
        public DateTime DateCreated { get; }
        public DateTime DateModified { get; }
        public bool IsWeb { get; }

        public AccessObjectModel(AccessObject @object)
        {
            Object = @object ?? throw new ArgumentNullException(nameof(@object));

            Name = @object.Name;
            FullName = @object.FullName;
            IsLoaded = @object.IsLoaded;
            Type = ((AcObjectType)@object.Type).ToString();
            Attributes = @object.Attributes;
            DateCreated = @object.DateCreated;
            DateModified = @object.DateModified;
            IsWeb = @object.IsWeb;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (!(obj is AccessObjectModel))
                return 1;

            var model = (AccessObjectModel)obj;

            return model.FullName == this.FullName && model.Name == this.Name ? 0 : 1;// && model.Form.GetDependencyInfo().Dependants.
        }
    }
}
