using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    public class UsingCompany
    {
        public enum FlowType
        {
            Incoming, Sold, WrittenOff, Transferred
        }
        public Company Company { get; set; }
        public UsingCompany(Company company)
        {
            Company = company;
        }
        public List<FlowType> Flows { get; set; } = new List<FlowType>();

        public void AddFlow(FlowType flowType, int Amount) 
        {
            if (Amount <= 0 && (flowType == FlowType.Incoming)) { throw new ArgumentException("Less 0"); }

            switch (flowType)
            {
                case FlowType.Incoming:
                    Company.NewQuantity(Amount);
                    Flows.Add(flowType);
                    break;

                case FlowType.Sold:
                case FlowType.WrittenOff:
                case FlowType.Transferred:
                    Company.NewQuantity(-Amount);
                    Flows.Add(flowType);
                    break;
            }
        }
    }
}
