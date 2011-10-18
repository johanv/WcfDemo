-- Data.sql - stored procedure die de backend gebruikt
-- Copyright (C) 2011  Johan Vervloet
--
-- This program is part of WcfDemo.
-- WcfDemo is free software: you can redistribute it and/or modify
-- it under the terms of the GNU General Public License as published by
-- the Free Software Foundation, either version 3 of the License, or
-- (at your option) any later version.
--
-- WcfDemo is distributed in the hope that it will be useful,
-- but WITHOUT ANY WARRANTY; without even the implied warranty of
-- MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
-- GNU General Public License for more details.
--
-- You should have received a copy of the GNU General Public License
-- along with this program.  If not, see <http://www.gnu.org/licenses/>.


CREATE PROCEDURE [dbo].[HelloWorld]
	@result VARCHAR(MAX) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT @result = 'Hello World!';
END
