drop database if exists abcrecipe;
create database abcrecipe;
use abcrecipe;

drop table if exists User;
create table IF NOT EXISTS User(
	user_name varchar(100) not null,
	hash_password varchar(100) not null,
	primary key(user_name)
);

drop table if exists Profile;
create table IF NOT EXISTS Profile(
	profile_id int auto_increment not null,
	first_name varchar(100) not null,
	user_name varchar(100) not null,
	last_name varchar(100) not null,
	email varchar(100) not null UNIQUE,
	diet varchar(20) not null,
	foreign key(user_name) references User(user_name) on delete cascade on update cascade,
	primary key(profile_id)
;

drop table if exists Uploads;
create table IF NOT EXISTS Uploads(
	user_name varchar(100) not null,
	recipe_id int not null,
	upload_date date not null,
	foreign key(user_name) references User(user_name) on delete cascade on update cascade,
	foreign key(recipe_id) references Recipe(recipe_id) on delete cascade on update cascade,
	primary key(user_name,recipe_id)
);

drop table if exists Instructions;
create table IF NOT EXISTS Instructions(
	instruction_id int auto_increment not null,
	task varchar(255) not null,
	instruction_order int not null,
	primary key(instruction_id)
);

drop table if exists Recipe;
create table IF NOT EXISTS Recipe(
	recipe_id int auto_increment not null,
	title varchar(100) not null,
	description varchar(100) not null,
	ingredients varchar(300) not null,
	prep_time varchar(100) not null,
	recipe_type varchar(100) not null,
	img_src varchar(255) not null,
	instruction_id int not null,
	foreign key(instruction_id) references Instructions(instruction_id) on delete cascade on update cascade,
	primary key(recipe_id)
);
