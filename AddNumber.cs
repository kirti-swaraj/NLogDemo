using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    public class AddNumber
    {
        private readonly NLog nLog = new NLog();
        public int Add(int firstNumber, int secondNumber)
        {
            /// Validation to check whether the number is greater than zero
            if (firstNumber == 0 || secondNumber == 0)
            {
                /// just to mark a flag that this operation was unsuccessful
                nLog.LogDebug("Debug Unsuccessful: Add()");
                /// just to make a note that whatever values are enter should be greater than zero
                nLog.LogError("Values entered by the user was not greater than zero.");
                /// just to make a note that warning values should not be zero
                nLog.LogWarn("First number or Second number should not be zero.");
            }
            /// addtion of two numbers
            int sum = firstNumber + secondNumber;
            nLog.LogDebug("Debug Succesful: Add()");
            nLog.LogInfo("Add() passed: " + sum);
            return sum;
        }
    }
}
