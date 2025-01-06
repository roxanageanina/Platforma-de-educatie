USE EducatieStiinteNaturale;
GO

INSERT INTO Utilizatori (Nume, Prenume, Username, Email, Parola, TipCont) 
VALUES 
('Popescu', 'Ion', 'ion.popescu', 'ion.popescu@student.com', 'parola123', 'Student'),
('Ionescu', 'Maria', 'maria.ionescu', 'maria.ionescu@student.com', 'Parola123!', 'Student'),
('Oprea', 'Florin', 'florin.oprea', 'florin.oprea@student.com', 'parola456!', 'Student'),
('Georgescu', 'Ana', 'ana.georgescu', 'ana.georgescu@profesor.com', 'parola1235', 'Profesor'),
('Dumitrescu', 'Radu', 'radu.dumitrescu', 'radu.dumitrescu@profesor.com', 'Parola123', 'Profesor'),
('Oprisor', 'Marian', 'admin', 'admin@educatie.com', 'admin123', 'Administrator');
GO

INSERT INTO Utilizatori (Nume, Prenume, Username, Email, Parola, TipCont) 
VALUES 
('Iliescu', 'Iulian', 'iulian.iliescu', 'iulian.iliescu@profesor.com', 'parola123', 'Profesor'),
('Andone', 'Cristina', 'cristina.andone', 'cristina.andone@profesor.com', 'Parola123!', 'Profesor');
GO

SELECT * FROM Utilizatori;

INSERT INTO Materii (NumeMaterie, Descriere) 
VALUES 
('Biodiversitate', 'Studiul diversitatii biologice, incluzand animale, plante si ecosisteme.'),
('Geologie', 'Analiza structurilor, proceselor si istoriei geologice ale Pamantului.'),
('Ecologie', 'Explorarea interactiunilor dintre organisme si mediul lor.'),
('Fenomene naturale', 'Examinarea fenomenelor naturale precum cutremure, furtuni sau eruptii vulcanice.');
GO

SELECT * FROM Materii;

INSERT INTO Teste (NumeTest, ID_Materie, Autor) 
VALUES 
('Test biodiversitate 1', 1, 4),
('Test biodiversitate 2', 1, 4),
('Test geologie 1', 2, 5),
('Test geologie 2', 2, 5),
('Test ecologie 1', 3, 7),
('Test ecologie 2', 3, 7),
('Test fenomene naturale 1', 4, 8),
('Test fenomene naturale 2', 4, 8);

SELECT * FROM Teste;

-- test biodiversitate 1
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(1, 'Ce reprezinta biodiversitatea?', 2.0),
(1, 'Care este rolul biodiversitatii in ecosisteme?', 2.0),
(1, 'Cum este masurata biodiversitatea?', 2.0),
(1, 'Ce este un habitat?', 2.0),
(1, 'Care sunt factorii care ameninta biodiversitatea?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(1, 'Diversitatea vietii de pe Pamant', 1),
(1, 'Numarul de planete dintr-un sistem solar', 0),
(1, 'Numarul speciilor intr-un ecosistem', 1),
(1, 'Durata ciclului vietii unei specii', 0),

(2, 'Stabilizarea ecosistemelor', 1),
(2, 'Reducerea resurselor naturale', 0),
(2, 'Cresterea numarului de specii', 0),
(2, 'Favorizarea interactiunilor intre organisme', 1),

(3, 'Prin studierea diversitatii genetice', 1),
(3, 'Prin numararea indivizilor dintr-o specie', 0),
(3, 'Prin analizarea ecosistemelor', 1),
(3, 'Prin studii climatice', 0),

(4, 'Locul unde traiesc organismele', 1),
(4, 'Un tip de ecosistem marin', 0),
(4, 'Un factor abiot al mediului', 0),
(4, 'Locatia unui ecosistem', 1),

(5, 'Defrisarile', 1),
(5, 'Cresterea populatiei de animale', 0),
(5, 'Schimbarile climatice', 1),
(5, 'Formarea unor habitate noi', 0);

--test biodiversitate 2
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(2, 'Ce sunt speciile endemice?', 2.0),
(2, 'Cum influenteaza diversitatea genetica supravietuirea speciilor?', 2.0),
(2, 'Care este impactul invaziilor biologice asupra biodiversitatii?', 2.0),
(2, 'Cum contribuie conservarea biodiversitatii la sustenabilitate?', 2.0),
(2, 'Care sunt masurile eficiente de protejare a biodiversitatii?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(6, 'Specii care traiesc doar intr-o anumita regiune', 1),
(6, 'Specii comune in toate ecosistemele', 0),
(6, 'Specii care migreaza sezonier', 0),
(6, 'Specii disparute recent', 0),

(7, 'Reduce vulnerabilitatea la schimbari de mediu', 1),
(7, 'Favorizeaza mutatiile daunatoare', 0),
(7, 'Creste rata de extinctie a speciilor', 0),
(7, 'Asigura adaptarea la noi conditii', 1),

(8, 'Competitia si eliminarea speciilor native', 1),
(8, 'Crearea de noi ecosisteme', 0),
(8, 'Reducerea diversitatii genetice', 1),
(8, 'Imbunatatirea stabilitatii ecosistemelor', 0),

(9, 'Ofera servicii ecosistemice esentiale', 1),
(9, 'Creste costurile economice', 0),
(9, 'Imbunatateste calitatea vietii umane', 1),
(9, 'Reduce poluarea globala', 0),

(10, 'Crearea de arii protejate', 1),
(10, 'Educatia ecologica', 1),
(10, 'Dezvoltarea necontrolata', 0),
(10, 'Restaurarea ecosistemelor degradate', 1);

--test geologie 1
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(3, 'Ce este un mineral?', 2.0),
(3, 'Cum sunt formate rocile sedimentare?', 2.0),
(3, 'Care este structura unei roci metamorfice?', 2.0),
(3, 'Ce reprezinta ciclul rocilor?', 2.0),
(3, 'Cum putem identifica un mineral?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(11, 'Un compus natural solid', 1),
(11, 'Un material sintetic', 0),
(11, 'Un tip de roca vulcanica', 0),
(11, 'Un amestec de materiale organice', 0),

(12, 'Prin acumularea de sedimente', 1),
(12, 'Prin racirea magmei', 0),
(12, 'Prin activitate tectonica', 0),
(12, 'Prin eroziunea mineralelor', 1),

(13, 'Cristale aranjate sub presiune', 1),
(13, 'Sedimente amestecate', 0),
(13, 'Magma solidificata', 0),
(13, 'Structura schistului', 1),

(14, 'Transformarea rocilor in alte tipuri', 1),
(14, 'Procesul de eroziune', 0),
(14, 'Formarea rocilor vulcanice', 0),
(14, 'Ciclul apei in natura', 0),

(15, 'Dupa culoare si duritate', 1),
(15, 'Dupa temperatura de topire', 0),
(15, 'Dupa forma sedimentelor', 0),
(15, 'Dupa stralucirea suprafetei', 1);

--test geologie 2
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(4, 'Ce sunt rocile vulcanice?', 2.0),
(4, 'Care este procesul de formare al granitului?', 2.0),
(4, 'Ce determina culoarea mineralelor?', 2.0),
(4, 'Cum se clasifica rocile?', 2.0),
(4, 'Care este rolul placilor tectonice in formarea rocilor?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(16, 'Roci formate prin racirea magmei', 1),
(16, 'Roci sedimentare solidificate', 0),
(16, 'Roci formate din fragmente de minerale', 0),
(16, 'Materiale produse de eruptii', 1),

(17, 'Racirea lenta a magmei subterane', 1),
(17, 'Compresia sedimentelor', 0),
(17, 'Depozitarea mineralelor', 0),
(17, 'Eroziunea bazaltului', 0),

(18, 'Elementele chimice continute', 1),
(18, 'Forma cristalului', 0),
(18, 'Duritatea mineralelor', 0),
(18, 'Originea geologica', 1),

(19, 'In functie de formare si compozitie', 1),
(19, 'Dupa greutatea specifica', 0),
(19, 'Dupa regiunea geografica', 0),
(19, 'Dupa temperatura formarii', 1),

(20, 'Muta rocile in alte locuri', 1),
(20, 'Creaza noi tipuri de roci', 1),
(20, 'Distruge straturile sedimentare', 0),
(20, 'Formeaza vulcanii', 1);

--test ecologie 1
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(5, 'Ce este ecologia?', 2.0),
(5, 'Ce sunt factorii biotici?', 2.0),
(5, 'Care sunt relatiile dintre organisme?', 2.0),
(5, 'Ce este un ecosistem?', 2.0),
(5, 'Cum afecteaza oamenii ecosistemele?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(21, 'Studiul interactiunilor organismelor', 1),
(21, 'O ramura a geologiei', 0),
(21, 'Analiza resurselor naturale', 0),
(21, 'Studiul diversitatii genetice', 1),

(22, 'Organismele vii dintr-un mediu', 1),
(22, 'Conditiile fizice ale mediului', 0),
(22, 'Procesele chimice din ecosistem', 0),
(22, 'Plantele si animalele', 1),

(23, 'Concurenta si cooperarea', 1),
(23, 'Interactiuni abiotice', 0),
(23, 'Evolutia speciilor', 0),
(23, 'Relatii trofice si mutualism', 1),

(24, 'Un sistem format din organisme si mediu', 1),
(24, 'Un tip de habitat', 0),
(24, 'O retea trofica', 1),
(24, 'O regiune biogeografica', 0),

(25, 'Poluarea mediului', 1),
(25, 'Epuizarea resurselor', 1),
(25, 'Protejarea speciilor pe cale de disparitie', 0),
(25, 'Extinderea habitatelor naturale', 0);

--test ecologie 2
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(6, 'Ce sunt factorii abiotici?', 2.0),
(6, 'Ce este un lant trofic?', 2.0),
(6, 'Cum functioneaza ciclul carbonului?', 2.0),
(6, 'Care sunt principalele tipuri de ecosisteme?', 2.0),
(6, 'Cum influenteaza clima un ecosistem?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(26, 'Conditiile fizice si chimice ale mediului', 1),
(26, 'Organismele care traiesc intr-un mediu', 0),
(26, 'Resursele naturale dintr-un ecosistem', 0),
(26, 'Energie solara si precipitatii', 1),

(27, 'Secventa de organisme care transfera energie', 1),
(27, 'O retea de habitate', 0),
(27, 'Relatiile de concurenta dintr-un ecosistem', 0),
(27, 'Interactiunea factorilor biotici si abiotici', 1),

(28, 'Prin fotosinteza si respiratie', 1),
(28, 'Prin acumularea carbonului in sol', 1),
(28, 'Prin reactii chimice din apa', 0),
(28, 'Prin eruptii vulcanice', 0),

(29, 'Ecosisteme terestre, acvatice si mixte', 1),
(29, 'Doar ecosisteme tropicale si polare', 0),
(29, 'Ecosisteme marine si desertice', 1),
(29, 'Ecosisteme doar pe uscat', 0),

(30, 'Stabileste temperatura si umiditatea', 1),
(30, 'Creste biodiversitatea in zone aride', 0),
(30, 'Influenta asupra migratiei speciilor', 1),
(30, 'Reduce interactiunile intre organisme', 0);

--test fenomene naturale 1
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(7, 'Ce sunt fenomenele naturale?', 2.0),
(7, 'Care sunt tipurile principale de fenomene naturale?', 2.0),
(7, 'Cum se formeaza un cutremur?', 2.0),
(7, 'Ce este un vulcan activ?', 2.0),
(7, 'Cum se produce un tsunami?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(31, 'Evenimente care apar in natura', 1),
(31, 'Actiuni umane asupra mediului', 0),
(31, 'Schimbari climatice lente', 0),
(31, 'Eruptii vulcanice si furtuni', 1),

(32, 'Geologice, meteorologice, hidrologice', 1),
(32, 'Doar fenomene atmosferice', 0),
(32, 'Evenimente provocate de oameni', 0),
(32, 'Doar cutremure si inundatii', 0),

(33, 'Din miscare placilor tectonice', 1),
(33, 'Din activitatea vulcanilor', 0),
(33, 'Din acumularea apei subterane', 0),
(33, 'Din topirea ghetarilor', 0),

(34, 'Un vulcan care poate erupe', 1),
(34, 'Un vulcan care a erupt recent', 1),
(34, 'Un vulcan care nu mai erupe niciodata', 0),
(34, 'Un tip de munte', 0),

(35, 'Din cutremure submarine', 1),
(35, 'Din valurile oceanice mari', 0),
(35, 'Din schimbarile de presiune atmosferica', 0),
(35, 'Din eruptii vulcanice submarine', 1);

--test fenomene naturale 2
INSERT INTO Intrebari (ID_Test, TextIntrebare, Punctaj)
VALUES
(8, 'Ce este o tornada?', 2.0),
(8, 'Cum se formeaza un uragan?', 2.0),
(8, 'Ce sunt inundatiile?', 2.0),
(8, 'Cum afecteaza fenomenele naturale ecosistemele?', 2.0),
(8, 'Ce este o seceta?', 2.0);

INSERT INTO Raspunsuri (ID_Intrebare, TextRaspuns, EsteCorect)
VALUES
(36, 'Un vartej de aer violent', 1),
(36, 'Un tip de ploaie torentiala', 0),
(36, 'Un fenomen de eroziune', 0),
(36, 'Un curent oceanic rapid', 0),

(37, 'Din acumularea de caldura in ocean', 1),
(37, 'Din vanturile reci ale Arcticii', 0),
(37, 'Din furtuni de zapada', 0),
(37, 'Din schimbarea nivelului marii', 0),

(38, 'Revarsarea apelor peste maluri', 1),
(38, 'Formarea lacurilor noi', 0),
(38, 'Disparitia raurilor mici', 0),
(38, 'Schimbarea curentilor de apa', 0),

(39, 'Distrug resursele naturale', 1),
(39, 'Cresc biodiversitatea', 0),
(39, 'Favorizeaza interactiunile pozitive', 0),
(39, 'Pot distruge habitatele', 1),

(40, 'O perioada lunga fara precipitatii', 1),
(40, 'Lipsa apei in lacuri', 0),
(40, 'Un fenomen de desertificare rapida', 1),
(40, 'O crestere brusca a temperaturii', 0);

SELECT * FROM Intrebari;

SELECT * FROM Raspunsuri;

DROP TABLE Raspunsuri;
DROP TABLE Intrebari;
DROP TABLE Teste;
DROP TABLE Materii;
DROP TABLE Utilizatori;




