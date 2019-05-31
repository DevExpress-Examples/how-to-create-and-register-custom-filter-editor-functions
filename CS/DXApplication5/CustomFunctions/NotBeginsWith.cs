using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXSample.CustomFunctions {
    public class NotBeginsWithFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "NotBeginsWith";
        static readonly NotBeginsWithFunction instance = new NotBeginsWithFunction();
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(instance);
        }
        public FunctionCategory Category {
            get { return FunctionCategory.Text; }
        }
        public string Description {
            get { return "<description>"; }
        }
        public bool IsValidOperandCount(int count) {
            return count == 2;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(string);
        }
        public int MaxOperandCount {
            get { return 2; }
        }
        public int MinOperandCount {
            get { return 2; }
        }
        public object Evaluate(params object[] operands) {
            if(operands[0] != null && operands[1] != null) {
                string str1 = operands[0].ToString();
                string str2 = operands[1].ToString();
                return !str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }
        public string Name {
            get { return FunctionName; }
        }
        public string DisplayName {
            get { return "Not begins with"; }
        }
        public object Image {
            get {return "FontSizeDecrease;Office2013"; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
    }
}
