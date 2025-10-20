ALTER TABLE Cliente
ADD CONSTRAINT unique_nome_cliente UNIQUE (nome);

        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
    }
}
