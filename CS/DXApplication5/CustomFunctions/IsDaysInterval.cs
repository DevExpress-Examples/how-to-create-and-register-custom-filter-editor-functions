using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXSample {
    class IsDaysInterval : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "IsDaysInterval";
        static readonly IsDaysInterval instance = new IsDaysInterval();

        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(instance);
        }
        public FunctionCategory Category {
            get { return FunctionCategory.DateTime; }
        }
        public string Description {
            get { return "<description>"; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 2;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return operandIndex == 0 && type == typeof(DateTime) || operandIndex == 1 && type == typeof(int);
        }
        public int MaxOperandCount {
            get { return 2; }
        }
        public int MinOperandCount {
            get { return 2; }
        }
        public object Evaluate(params object[] operands) {
            DateTime dt = Convert.ToDateTime(operands[0]);
            int days = Convert.ToInt32(operands[1]);
            DateTime start = DateTime.Today.AddDays(-days);
            DateTime end = DateTime.Today.AddDays(days);
            return dt >= start && dt <= end;
        }
        public string Name {
            get { return FunctionName; }
        }
        public string DisplayName {
            get { return "Is days interval"; }
        }
        public object Image {
            get { return "SwitchTimeScalesTo;Size16x16;Colored"; }
        }

        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
    }
}
