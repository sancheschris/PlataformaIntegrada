USE Plataforma
GO

INSERT INTO Cliente 
VALUES
		('christian.santos@gmail.com', '1ahsudi3', 'SP'),
		('guilherme.sa@gmail.com', 'lsakd', 'MG'),
		('alisson.santos@gmail.com', 'qertyrew', 'MG'),
		('edna.san7@hotmail.com', 'alokasdsj', 'GO'),
		('adalbertolopes@hotmail.com', '12345ddfg', 'AC'),
		('alexmessias@hotmail.com', 'kokkdso', 'AC'),
		('ari.raposo@hotmail.com', 'erty', 'SP'),
		('fabiomelo@gmail.com', 'asdfgh', 'RJ'),
		('julianolobo@gmail.com', 'lkgfdks', 'SP'),
		('sergiovasconcelos@gmail.com', 'senha12345', 'DF'),
		('suelifatima@gmail.com', '7654321', 'DF'),
		('andrecarneiro@hotmail.com', '1234321', 'RJ')

INSERT INTO Item
VALUES
		('Jogo Fifa19', '129.90', '100'),
		('Jogo Star Wars', '59.90', '30'),
		('Jogo NFL 2019', '100.0', '45'),
		('Jogo Destiny', '134.98', '65'),
		('Jogo Pokemon', '129.90', '100'),
		('Jogo God of War 4', '79.99', '25'),
		('Jogo Gears of Wars', '39.99', '45'),
		('Jogo Halo 5', '45.90', '16'),
		('Jogo Street Fighter 5', '80.0', '35'),
		('Jogo Uncharted 4', '69.99', '50'),
		('Jogo Resident Evil 2 Remake', '199.99', '150'),
		('Jogo NBA2k9', '159.99', '120')

INSERT INTO PedidoVenda
VALUES

		('10/01/2019', '05/01/2019', '0.50', '100.90', 1),
		('01/02/2019', '06/01/2019', '0.15', '169.90', 2),
		('05/03/2019', '12/20/2019', '0.35', '129.90', 3),
		('10/01/2019', '10/03/2019', '0.90', '199.99', 4),
		('05/19/2019', '05/25/2019', '0.35', '199.99', 5),
		('03/04/2019', '03/08/2019', '0.35', '139.99', 6),
		('05/03/2019', '05/09/2019', '0.50', '159.99', 7),
		('12/22/2018', '12/29/2018', '0.60', '129.90', 8),
		('04/11/2018', '04/12/2018', '0.80', '99.90', 9)

INSERT INTO PedidoVendaLinhas
VALUES
		('129.90', '1', 1),
		('59.90', '1', 2),
		('100.0', '1', 3),
		('134.98', '1', 4),
		('129.90', '1', 5)