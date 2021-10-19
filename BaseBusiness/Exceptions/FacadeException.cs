using System;
using BMS.Utils;
using BMS.Facade;
using BMS.Exceptions;
using BMS.Business;
using BMS.Model;
namespace BMS.Exceptions
{
	public class FacadeException : Exception
	{
		public FacadeException(String message) : base(message)
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public FacadeException(Exception e)
		{			
		}
	}
}