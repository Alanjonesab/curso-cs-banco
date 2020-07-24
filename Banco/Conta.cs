using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco {
    class Conta {

        public string NumeroConta { get; private set;}
        private string _nome;
        public double Saldo { get; private set;}

        public Conta(string numeroConta, string nome) {
            NumeroConta = numeroConta;
            _nome = nome;
            
        }
        public Conta (string numeroConta, string nome, double depositoInicial) : this (numeroConta, nome) {
            Deposito(depositoInicial);
        }

        public string Nome {

            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        
        
        public void Deposito(double valor) {

            Saldo += valor; 
        }

        public void Saque(double valor) {

            Saldo -= (valor + 5);
        }

        public override string ToString() {
            return "Conta: " +
                    NumeroConta +
                    "\nNome do Titular: " +
                    Nome +
                    "\nSaldo: R$ " +
                    Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
