using System.Globalization;
namespace Course {
    class ContaBancária {
                
        public int _conta { get; private set; }
        public string _titular { get; private set; }
        
        public double _saldo { get; private set; }

        public ContaBancária(int conta, string titular) {
            _conta = conta;
            _titular = titular;
            
        }

        public ContaBancária(int conta, string titular, double saldo) :this(conta, titular) {
           
            _saldo = saldo;
        }                      
                
        public void Depositar(double valorDepósito)            
            {
                _saldo += valorDepósito;
            }
        public void Sacar(double saque) {
            _saldo -= saque + 5;
        }
        public override string ToString() {
            return "Conta " + _conta + ", Titular " + _titular + ", Saldo: R$ " + _saldo;}

    }

        

        
        }