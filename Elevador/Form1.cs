using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {
        private Elevator elevador;
        private int auxAndar;
        private int auxProxAndar;
        public int i = 0;
        public int cont;

        public Form1()
        {
            InitializeComponent();

            elevador = new Elevator();
            elevador.ElevatorEvent += mudarAndar;
            txtboxAndar.Text = (elevador.andarAtual).ToString();
        }

        public async void mudarAndar(object sender, EventArgs e)
        {
            cont = 0;
            finalizar(cont);
            auxAndar = elevador.andarAtual;
            auxProxAndar = elevador.proximoAndar;
            
            if (auxAndar != auxProxAndar)
            {
                if (auxAndar < auxProxAndar)
                {

                    for (i = auxAndar; i <= auxProxAndar; i++)
                    {
                        txtboxAndar.Text = i.ToString();
                        txtboxSituacao.Text = "Cheguei aqui - Subindo";
                        await transicao();
                    }
                    elevador.andarAtual = elevador.proximoAndar;
                    txtboxAndar.Text = (elevador.andarAtual).ToString();
                    await transicao();
                }
                else if (auxAndar > auxProxAndar)
                {

                    for (i = auxAndar;i >= auxProxAndar; i--)
                    {
                        txtboxAndar.Text = i.ToString();
                        txtboxSituacao.Text = "Cheguei aqui - Descendo";
                        await transicao();
                    }
                    elevador.andarAtual = elevador.proximoAndar;
                    txtboxAndar.Text = (elevador.andarAtual).ToString();
                    await transicao();
                }
            }

            cont = 1;
            await finalizar(cont);
        }

        static async Task transicao()
        {
            await Task.Delay(2000);
        }

        static async Task<int> finalizar(int a)
        {
            
            int codRodando = a;
            int auxCodRodando;

            if (codRodando == 0)
            {
                await Task.Delay(100);
                return codRodando;

            } else if (codRodando == 1)
            {
                codRodando = 1;
                await Task.Delay(100);
                return codRodando;

            } else
            {
                if(codRodando == 0)
                {
                    auxCodRodando = 0;
                    await Task.Delay(100);
                    return auxCodRodando;

                } else if (codRodando == 1)
                {
                    auxCodRodando = 1;
                    await Task.Delay(100);
                    return auxCodRodando;
                }
                return codRodando;
            }

            
           
        }

        //public bool calculos()
        //{
        //    int a = elevador.andarAtual;
        //    int b = elevador.proximoAndar;
        //    bool valor = false;

        //    if ((a < b) || (a > b))
        //    {
        //        valor = true;
        //    }
        //    else if (a == b)
        //    {
        //        valor = false;
        //    }
            
        //    return valor;
        //}


        private async void terreo_Click(object sender, EventArgs e)
        {
            var valor = finalizar(2);
            int c = valor.Result;
            if (c == 0)
            {
                await valor;
            } else
            {
                elevador.proximoAndar = 0;
                elevador.doElevator();
            }
                
        }

        private async void andar1_Click(object sender, EventArgs e)
        {
            var valor = finalizar(2);
            int c = valor.Result;
            if (c == 0)
            {
                await valor;
            }
            else
            {
                elevador.proximoAndar = 1;
                elevador.doElevator();
            }
        }

        private async void andar2_Click(object sender, EventArgs e)
        {
            var valor = finalizar(2);
            int c = valor.Result;
            if (c == 0)
            {
                await valor;
            }
            else
            {
                elevador.proximoAndar = 2;
                elevador.doElevator();
            }
        }

        private async void  andar3_Click(object sender, EventArgs e)
        {
            var valor = finalizar(2);
            int c = valor.Result;
            if (c == 0)
            {
                await valor;
            }
            else
            {
                elevador.proximoAndar = 3;
                elevador.doElevator();
            }
        }

        private async void andar4_Click(object sender, EventArgs e)
        {
            var valor = finalizar(2);
            int c = valor.Result;
            if (c == 0)
            {
                await valor;
            }
            else
            {
                elevador.proximoAndar = 4;
                elevador.doElevator();
            }

        }
        
    }
}

    
