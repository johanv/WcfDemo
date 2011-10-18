// HelloService.svc.cs - de implementatie van de service methods
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

using System.Security.Permissions;
using Backend;

namespace Service
{
    /// <summary>
    /// Implementatie van de HelloService
    /// </summary>
    public class HelloService : IHelloService
    {
        /// <summary>
        /// Zeg hallo.
        /// </summary>
        /// <returns>Een hello-world string</returns>
        [PrincipalPermission(SecurityAction.Demand, Name = @"KIPDORP\VervlJo")] 
        public string SayHello()
        {
            var hw = new HelloWorld();
            return hw.SayHello();
        }
    }
}
