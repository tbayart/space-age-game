CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
--
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;

CREATE TABLE `agents` (
  `AgentID` int(11) NOT NULL,
  `AgentName` varchar(45) NOT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Telephone` varchar(45) DEFAULT NULL,
  `Debt` int(11) NOT NULL,
  `InitialDebt` int(11) NOT NULL,
  `InitialDate` date NOT NULL,
  PRIMARY KEY (`AgentID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dump completed on 2011-12-25 22:13:02
