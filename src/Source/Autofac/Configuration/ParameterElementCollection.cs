﻿// This software is part of the Autofac IoC container
// Copyright (c) 2007 - 2008 Autofac Contributors
// http://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System.Collections.Generic;

namespace Autofac.Configuration
{
    /// <summary>
    /// A collection of parameter elements.
    /// </summary>
    public class ParameterElementCollection : NamedConfigurationElementCollection<ParameterElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterElementCollection"/> class.
        /// </summary>
        public ParameterElementCollection()
            : base("parameter", ParameterElement.Key)
        {
        }

        /// <summary>
        /// Return the collection as a dictionary.
        /// </summary>
        /// <returns>The collection as a dictionary.</returns>
        public IDictionary<string, object> ToDictionary()
        {
            var result = new Dictionary<string, object>();
            foreach (ParameterElement parameter in this)
                result.Add(parameter.Name, parameter.Value);
            return result;
        }
    }
}