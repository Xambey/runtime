// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System.Data{
    using System;

    public interface IDbTransaction : IDisposable {

        IDbConnection Connection {
            get;
        }

        IsolationLevel IsolationLevel {
            get;
        }

        void Commit();

        //IDbCommand CreateCommand(); // MDAC 68309

        void Rollback();
    }
}    

