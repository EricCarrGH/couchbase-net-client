﻿using System;
using System.Runtime.Serialization;

namespace Couchbase.Core
{
    /// <summary>
    /// Thrown when a mutation has been detected while observing a document.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class DocumentMutationException : Exception
    {
        public DocumentMutationException()
        {
        }

        public DocumentMutationException(string message)
            : base(message)
        {
        }

        public DocumentMutationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DocumentMutationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2015 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
