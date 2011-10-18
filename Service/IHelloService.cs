// IHelloService - het servicecontract
// Copyright (C) 2011  Johan Vervloet
//
// This program is part of WcfDemo.
// WcfDemo is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// WcfDemo is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.ServiceModel;

namespace Service
{
    /// <summary>
    /// Service contract voor de HelloWorld service
    /// </summary>
    [ServiceContract]
    public interface IHelloService
    {
        /// <summary>
        /// Zeg hallo.
        /// </summary>
        /// <returns>Een hello-world string</returns>
        [OperationContract]
        string SayHello();
    }
}
