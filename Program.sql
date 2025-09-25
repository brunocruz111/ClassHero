SELECT nome,
       INSTR(UPPER(nome), 'SOUZA') AS posicao
FROM clientes
WHERE UPPER(nome) LIKE '%SOUZA%';
