﻿using System;
using System.ServiceModel;
using WcfServiceCore.DataContracts.DataContracts;

namespace WcfServiceCore.DataContracts.ServiceContracts
{
    [ServiceContract(CallbackContract = typeof(IServiceContractsCallback))]
    public interface IServiceContracts
    {
        [OperationContract]
        bool UserExists(string userName);

        [OperationContract]
        string SetUserData(string userName, string firstName, string lastName, DateTime birthDate, string email);

        [OperationContract]
        UserData GetUserData(string userName);

        [OperationContract]
        void SendMessage(string senderUserName, string receiverUserName, string message);

        [OperationContract]
        bool TrySignIn(string userName, string password);

        [OperationContract]
        bool ValidateAddress(string emailAddress);
    }
}
