CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19


--
-- Temporary table structure for view `paid`
--

DROP TABLE IF EXISTS `paid`;

CREATE  OR REPLACE VIEW `Store`.`Collected` AS SELECT        SUM(Amount) AS CollectedTotal   FROM            payments;
CREATE  OR REPLACE VIEW `Store`.`Paid` AS SELECT        SUM(Ammount) AS PaidTotal    FROM            dealerpayments;
