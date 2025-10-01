ALTER TABLE Empregado
ADD CONSTRAINT chk_ativo
CHECK (ativo IN (0, 1));
