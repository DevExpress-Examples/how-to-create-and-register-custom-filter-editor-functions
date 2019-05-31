using DevExpress.Data.Filtering;
using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXSample {
    public class IsWeekendFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "IsWeekend";
        static readonly IsWeekendFunction instance = new IsWeekendFunction();

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
            get { return "TEST TEST>"; }
        }

        public bool IsValidOperandCount(int count) {
            return count == 1;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(DateTime);
        }
        public int MaxOperandCount {
            get { return 1; }
        }
        public int MinOperandCount {
            get { return 1; }
        }
        public object Evaluate(params object[] operands) {
            DateTime dt = Convert.ToDateTime(operands[0]);
            return dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday;
        }
        public string Name {
            get { return FunctionName; }
        }
        public string DisplayName {
            get { return "Is weekend"; }
        }
        public object Image {
            get { return "DayView;Office2013"; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
    }
}
