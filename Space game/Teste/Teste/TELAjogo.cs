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

namespace Teste
{
    public partial class TELAjogo : Form
    {
        //INICIALIZAÇÃO:
        public TELAjogo()
        {
            InitializeComponent();

            pbCREDITOS.Visible = false;

            //COLOCA TODAS AS NAVES E BOLAS ASSOCIADAS COM O PB DO FUNDO:
            pbNAVEposicao1.Parent = pbFUNDO;
            pbNAVEposicao2.Parent = pbFUNDO;
            pbNAVEposicao3.Parent = pbFUNDO;
            pbNAVEposicao4.Parent = pbFUNDO;
            pbNAVEposicao5.Parent = pbFUNDO;
            pbNAVEposicao6.Parent = pbFUNDO;
            pbNAVEposicao7.Parent = pbFUNDO;

            BOLA1pcao1.Parent = pbFUNDO; 
            BOLA2pcao1.Parent = pbFUNDO; 
            BOLA3pcao1.Parent = pbFUNDO; 
            BOLA4pcao1.Parent = pbFUNDO; 
            BOLA5pcao1.Parent = pbFUNDO; 
            BOLA6pcao1.Parent = pbFUNDO; 
            BOLA7pcao1.Parent = pbFUNDO;
            //COLOCA TODAS AS NAVES E BOLAS TRANSPARENTES (DESTIVA ELAS).
            pbNAVEposicao1.Visible = false;
            pbNAVEposicao2.Visible = false;
            pbNAVEposicao3.Visible = false;
            pbNAVEposicao4.Visible = false;
            pbNAVEposicao5.Visible = false;
            pbNAVEposicao6.Visible = false;
            pbNAVEposicao7.Visible = false;

            BOLA1pcao1.Visible = false; 
            BOLA2pcao1.Visible = false; 
            BOLA3pcao1.Visible = false; 
            BOLA4pcao1.Visible = false; 
            BOLA5pcao1.Visible = false; 
            BOLA6pcao1.Visible = false; 
            BOLA7pcao1.Visible = false; 
            //COLOCA TODOS OS BOTÕES EXTRAS DESATIVADOS E INVISIVEIS:
            //Desativa:
            btnDIREITA.Enabled = false;
            btnESQUERDA.Enabled = false;
            btnCatirar.Enabled = false;
            btnBpausar.Enabled = false;

            //Deixa invisivel:
            btnDIREITA.Visible = false;
            btnESQUERDA.Visible = false;
            btnCatirar.Visible = false;
            btnBpausar.Visible = false;
        }


        //BOTÕES PARA O MENU:
        //BOTÃO COMEÇAR:
        private void btnJOGAR_Click(object sender, EventArgs e)
        {
            BOLA2pcao1.Visible = true;

            btnJOGAR.Enabled = false;
            btnCREDITOS.Enabled = false;
            btnSAIR.Enabled = false;
            btnJOGAR.Visible = false;
            btnCREDITOS.Visible = false;
            btnSAIR.Visible = false;

            //COLOCA TODOS OS BOTÕES EXTRAS ATIVADOS E VISIVEIS:
            //Ativa:
            btnDIREITA.Enabled = true;
            btnESQUERDA.Enabled = true;
            btnCatirar.Enabled = true;
            btnBpausar.Enabled = true;
            //Deixa visivel:
            btnDIREITA.Visible = true;
            btnESQUERDA.Visible = true;
            btnCatirar.Visible = true;
            btnBpausar.Visible = true;


            //DEIXA A NAVE DO MEIO APARENTE (COMEÇO DO GAME):
            pbNAVEposicao4.Visible = true;

            //SISTEMA DO GAME:
            sistemaJOGAR();
        }



        //BOTÃO CREDITOS:
        private void btnCREDITOS_Click(object sender, EventArgs e)
        {
            pbCREDITOS.Visible = true;
        }
        //BOTÃO SAIR:
        private void btnSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //BOTÕES PARA O JOGO:
        //BOTÃO ESQUERDA:
        private void btnESQUERDA_Click(object sender, EventArgs e)
        {
            MovimentoParaEsquerda();
        }
        //BOTÃO DIREITA:
        private void btnDIREITA_Click(object sender, EventArgs e)
        {
            MovimentoParaDireita();
        }
        //BOTÃO C (ATIRAR):
        private void btnCatirar_Click(object sender, EventArgs e)
        {
            Tiro();
        }
        //BOTÃO B (PAUSAR):
        private void btnBpausar_Click(object sender, EventArgs e)
        {
            //COLOCA TODAS AS NAVES TRANSPARENTES (DESTIVA ELAS).
            pbNAVEposicao1.Visible = false;
            pbNAVEposicao2.Visible = false;
            pbNAVEposicao3.Visible = false;
            pbNAVEposicao4.Visible = false;
            pbNAVEposicao5.Visible = false;
            pbNAVEposicao6.Visible = false;
            pbNAVEposicao7.Visible = false;

            BOLA1pcao1.Visible = false;
            BOLA2pcao1.Visible = false;
            BOLA3pcao1.Visible = false;
            BOLA4pcao1.Visible = false;
            BOLA5pcao1.Visible = false;
            BOLA6pcao1.Visible = false;
            BOLA7pcao1.Visible = false;

            //COLOCA OS BOTÕES DO MENU ATIVADO E VISIVEIS:
            //Ativa
            btnJOGAR.Enabled = true;
            btnSAIR.Enabled = true;
            btnCREDITOS.Enabled = true;
            //Deixa visivel
            btnJOGAR.Visible = true;
            btnSAIR.Visible = true;
            btnCREDITOS.Visible = true;

            //COLOCA TODOS OS BOTÕES EXTRAS DESATIVADOS E INVISIVEIS:
            //Desativa:
            btnDIREITA.Enabled = false;
            btnESQUERDA.Enabled = false;
            btnCatirar.Enabled = false;
            btnBpausar.Enabled = false;

            //Deixa invisivel:
            btnDIREITA.Visible = false;
            btnESQUERDA.Visible = false;
            btnCatirar.Visible = false;
            btnBpausar.Visible = false;
        }



            //DEMAIS AÇÕES E O RESTO:
            //Sistema do game:
            private void sistemaJOGAR()
            {   
               

            } 
             private void Tiro()
            {
                if ((pbNAVEposicao1.Visible == true) && (BOLA1pcao1.Visible == true))
                {
                BOLA1pcao1.Visible = false;
                BOLA7pcao1.Visible = true;
                }
                else if ((pbNAVEposicao2.Visible == true) && (BOLA2pcao1.Visible == true))
                {
                BOLA2pcao1.Visible = false;
                BOLA5pcao1.Visible = true;
                }
                else if ((pbNAVEposicao3.Visible == true) && (BOLA3pcao1.Visible == true))
                {
                BOLA3pcao1.Visible = false;
                BOLA6pcao1.Visible = true;
                }
                else if ((pbNAVEposicao4.Visible == true) && (BOLA4pcao1.Visible == true))
                {
                BOLA4pcao1.Visible = false;
                BOLA2pcao1.Visible = true;
                }
                else if ((pbNAVEposicao5.Visible == true) && (BOLA5pcao1.Visible == true))
                {
                BOLA5pcao1.Visible = false;
                BOLA1pcao1.Visible = true;
                }
                else if ((pbNAVEposicao6.Visible == true) && (BOLA6pcao1.Visible == true))
                {
                BOLA6pcao1.Visible = false;
                BOLA4pcao1.Visible = true;
                }
                else if ((pbNAVEposicao7.Visible == true) && (BOLA7pcao1.Visible == true))
                {
                BOLA7pcao1.Visible = false;
                BOLA3pcao1.Visible = true;
                }


            }
            //Movimento para esquerda:
            private void MovimentoParaEsquerda()
            {
            if (pbNAVEposicao7.Visible == true)
            {
                pbNAVEposicao7.Visible = false;
                pbNAVEposicao6.Visible = true;
            }
            else if (pbNAVEposicao6.Visible == true)
            {
                pbNAVEposicao6.Visible = false;
                pbNAVEposicao5.Visible = true;
            }
            else if (pbNAVEposicao5.Visible == true)
            {
                pbNAVEposicao5.Visible = false;
                pbNAVEposicao4.Visible = true;
            }
            else if (pbNAVEposicao4.Visible == true)
            {
                pbNAVEposicao4.Visible = false;
                pbNAVEposicao3.Visible = true;
            }
            else if (pbNAVEposicao3.Visible == true)
            {
                pbNAVEposicao3.Visible = false;
                pbNAVEposicao2.Visible = true;
            }
            else if (pbNAVEposicao2.Visible == true)
            {
                pbNAVEposicao2.Visible = false;
                pbNAVEposicao1.Visible = true;
            }
            else
            {
                pbNAVEposicao1.Visible = true;
            }
        }
        //Movimento para direita:
        private void MovimentoParaDireita()
        {
            if (pbNAVEposicao1.Visible == true)
            {
                pbNAVEposicao1.Visible = false;
                pbNAVEposicao2.Visible = true;
            }
            else if (pbNAVEposicao2.Visible == true)
            {
                pbNAVEposicao2.Visible = false;
                pbNAVEposicao3.Visible = true;
            }
            else if (pbNAVEposicao3.Visible == true)
            {
                pbNAVEposicao3.Visible = false;
                pbNAVEposicao4.Visible = true;
            }
            else if (pbNAVEposicao4.Visible == true)
            {
                pbNAVEposicao4.Visible = false;
                pbNAVEposicao5.Visible = true;
            }
            else if (pbNAVEposicao5.Visible == true)
            {
                pbNAVEposicao5.Visible = false;
                pbNAVEposicao6.Visible = true;
            }
            else if (pbNAVEposicao6.Visible == true)
            {
                pbNAVEposicao6.Visible = false;
                pbNAVEposicao7.Visible = true;
            }
            else
            {
                pbNAVEposicao7.Visible = true;
            }
        }

        private void TELAjogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Z")
            {
                btnESQUERDA.PerformClick();
            }

            if (e.KeyCode.ToString() == "X")
            {
                btnDIREITA.PerformClick();
            }

            if (e.KeyCode.ToString() == "C")
            {
                btnCatirar.PerformClick();
            }
            
            if (e.KeyCode.ToString() == "B")
            {
                btnBpausar.PerformClick();
            }
        }

        private void btnESQUERDA_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
