﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLogin.Dal;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public string cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}