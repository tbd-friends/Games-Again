--
-- Create 'manufacturers'
--

create table manufacturers (
    id serial constraint pk_manufacturers_id primary key,
    name varchar(100) not null,
    yearfounded smallint
);

--
-- populate 'manufacturers'
--

insert into manufacturers 
   ( id, name, yearfounded )
overriding system value
values
(1, 'Sony', 1946),
(2, 'Nintendo', 1889),
(3, 'Microsoft', 1975),
(4, 'Atari', 1972);

--
-- Create 'gamesystems'
-- 

create table gamesystems (
    id serial constraint pk_systems_id primary key, 
    name varchar(100) not null,
    manufacturerid int4 not null,
    yearReleased smallint,
    unitssold int4
);

--
-- populate 'systems'
-- 

insert into gamesystems
    ( id, name, manufacturerid, yearReleased )
overriding system value
values
(1, 'Playstation', 1, 1994),
(2, 'Playstation 2', 1, 2000),
(3, 'Famicom', 2, 1983),
(4, 'Nintendo Entertainment System', 2, 1985),
(5, 'Gamecube', 2, 2001),
(6, 'XBox', 3, 2001),
(7, '2600', 4, 1975);


-- 
-- Create 'games'
-- 

create table games (
    id serial constraint pk_games_id primary key,
    name varchar(100) not null,
    description varchar(500),
    gamesystemid int4 not null,
    yearReleased smallint
);

-- 
-- Populate 'games'
-- 

insert into games
    (id, name, description, gamesystemid, yearReleased )
overriding system value
values
(1, 'Crash Bandicoot', 'Set on the fictitious Wumpa Islands, an archipelago situated to the south of Australia where humans and mutant animals co-exist', 1, 1996),
(2, 'Rez', null, 2, 2001),
(3, 'Final Fantasy 3', null, 3, 1990),
(4, 'Mario Bros', 'Does it need a description?', 4, 1983),
(5, 'Resident Evil 4', null, 5, 2006),
(6, 'Crimson Skies', 'Flight Game', 6, 2003),
(7, 'Pong', 'TV Tennis', 7, 1975);