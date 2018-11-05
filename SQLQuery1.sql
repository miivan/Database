create TABLE Laboratory(L_number integer, L_name varchar(60), Profil varchar(60), PRIMARY KEY (L_number));

create TABLE Clinic (C_number integer, Name_clinic varchar(60), Laboratory integer, PRIMARY KEY (C_number),Foreign key (Laboratory) References Laboratory (L_number));

create TABLE Otdelenie(O_number integer, O_name varchar(60), Clinic integer, PRIMARY KEY (O_number),Foreign key (Clinic) References Clinic (C_number));

create TABLE Personal (P_number integer,FIO varchar(60),Doljnost varchar(20),Otdelenie integer, Clinic integer, b_Date date,PRIMARY KEY (P_number),Foreign key (Clinic) References Clinic (C_number), Foreign key (Otdelenie) References Otdelenie (O_number));

create TABLE Patient(Pa_number integer, FIO varchar(60), b_Date date, Clinic integer, post_Date date, Personal integer, Otdelenie integer, Diagnos varchar(60),PRIMARY KEY (Pa_number),Foreign key (Clinic) References Clinic (C_number), Foreign key (Personal) References Personal (P_number), Foreign key (Otdelenie) References Otdelenie (O_number));