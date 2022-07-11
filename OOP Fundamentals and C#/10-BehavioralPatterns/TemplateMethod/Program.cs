// See https://aka.ms/new-console-template for more information

using TemplateMethod;

var miner = new ExcelMiner();
miner.MineData();

var pdfMiner = new PDFMiner();
pdfMiner.MineData();