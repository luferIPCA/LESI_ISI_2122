#!/usr/bin/perl
# Altera nome de ficheiros

$path="./";
$ext="\.rar | \.zip";
opendir(DIR, "./$path") || die "Não consigo abrir \.\/\/$path: $!";
@files = grep { /(\.rar|\.zip|\.cs)/ && -f "./$path/$_" } readdir(DIR);
closedir DIR;


#while (<*.*>){
foreach(@files){
	#next;
	chomp;
	#print $_ . "\n";
	if (/(.*)([0-9]{2,4})(.*)(\.[a-zA-Z]{3})$/){
		$aux=$_;
		$aux =~ s/(.*)([0-9]{4})(.*)(\.[a-zA-Z]{3})/$2$4/ig;
		#print "FOUND File=  $1$3\n"; 
		print "Novo=$aux\n";
		#print "Antigo: $path$aux -> Novo= $path$_\n";
		rename ($path.$_,$path.$aux) || warn $!;
	}
}
print "done.\n";



