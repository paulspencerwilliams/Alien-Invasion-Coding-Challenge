delimiter $$

CREATE TABLE `alienInvasionUser` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(250) DEFAULT NULL,
  `score` int(11) DEFAULT '0',
  `currentCity` int(11) DEFAULT NULL,
  `failuresOnCurrentCity` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `idx_alienInvasionUser_name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8$$