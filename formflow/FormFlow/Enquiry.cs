using Microsoft.Bot.Builder.FormFlow;
using System;

namespace formflow.FormFlow
{
    [Serializable]
    public class Enquiry
    {
        [Prompt("What's your name?")]
        public string Name { get; set; }
        [Prompt("Can I ask which Company you work for?")]
        public string Company { get; set; }
        [Prompt("What is your Job Title there?")]
        public string JobTitle { get; set; }
        [Prompt("What's the best number to contact you on?")]
        public string Phone { get; set; }
        [Prompt("Can you think of anything else that would help us understand your needs?")]
        public string HowCanWeHelp { get; set; }
        [Prompt("We send out e-mail correspondence occasionally.  Would you like to receive offers and promotions from us? {||}")]
        public bool SignMeUpToTheMailingList { get; set; }
        [Prompt("Do you know which service you require from us? {||}")]

        public Service ServiceRequired { get; set; }

        public enum Service
        {
            Consultancy, Support, ProjectDelivery, Unknown
        }

        public static IForm<Enquiry> BuildEnquiryForm()
        {
            return new FormBuilder<Enquiry>()
                .Field("SignMeUpToTheMailingList")
                .Field("ServiceRequired")
                .AddRemainingFields()
                .Build();
        }
    }
}