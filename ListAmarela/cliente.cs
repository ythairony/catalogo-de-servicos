using System;

class Cliente{
    private int id;
    private string nome;
    private string sobrenome;
    private string cpf;
    private string email;
    private string sexo;
    private string endereco;
    private string bairro;
    private string cidade;
    private string telefone;
    private string senha;

    public Cliente(int id, string nome, string sobrenome, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, string senha) {
        this.id = id;
        if (nome != null) this.nome = nome;
        if (sobrenome != null) this.sobrenome = sobrenome;
        if (cpf != null) this.cpf = cpf;
        if (email != null) this.email = email;
        if (sexo != null) this.sexo = sexo;
        if (endereco != null) this.endereco = endereco;
        if (bairro != null) this.bairro = bairro;
        if (cidade != null) this.cidade = cidade;
        if (telefone != null) this.telefone = telefone;
        if (senha != null) this.senha = senha;
    }

    // Getters
    public string GetNome() { return this.nome; }
    public string GetSobrenome() { return this.sobrenome; }
    public string GetCpf() { return this.cpf; }
    public string GetEmail() { return this.email; }
    public string GetSexo() { return this.sexo; }
    public string GetEndereco() { return this.endereco; }
    public string GetBairro() { return this.bairro; }
    public string GetCidade() { return this.cidade; }
    public string GetTelefone() { return this.telefone; }
    public string GetSenha() { return this.senha; }

    // Setters
    public void SetNome(string nome) {
        if (nome != null) {
            this.nome = nome;
        }
    }
    public void SetSobrenome(string sobrenome) {
        if (nome != null) {
            this.sobrenome = sobrenome;
        }
    }
    public void SetCpf(string cpf) {
        if (cpf != null) {
            this.cpf = cpf;
        }
    }
    public void SetEmail(string email) {
        if (email != null) {
            this.email = email;
        }
    }
    public void SetSexo(string sexo) {
        if (sexo != null) {
            this.sexo = sexo;
        }
    }
    public void SetEndereco(string endereco) {
        if (endereco != null) {
            this.endereco = endereco;
        }
    }
    public void SetBairro(string endereco) {
        if (bairro != null) {
            this.bairro = bairro;
        }
    }
    public void SetCidade(string endereco) {
        if (cidade != null) {
            this.cidade = cidade;
        }
    }
    public void SetTelefone(string endereco) {
        if (telefone != null) {
            this.telefone = telefone;
        }
    }
    public void SetSenha(string endereco) {
        if (senha != null) {
            this.senha = senha;
        }
    }


    //ToString

    public override string ToString() { return $"Nome: {this.nome} {this.sobrenome} - Telefone: {this.telefone}"; }
}