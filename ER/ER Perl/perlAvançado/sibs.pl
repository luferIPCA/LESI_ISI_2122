#!/usr/bin/perl
#exercício do 1º Teste de ISI 

$path=".";
opendir(DIR, "./$path") || die "Não consigo abrir \.\/\/$path: $!";
@files = grep { /(\.INP)/ && -f "./$path/$_" } readdir(DIR);
closedir DIR;


#while (<*.*>){
foreach(@files){
	chomp;
	$f=$_;
	print "Open: $f ". "\n";	
	open (FILE,"./$path/$f") || warn "File $f inexistente...\n";;
	while (<FILE>){ 	
		if (/^0(.*)$/){
			print "HEADER= $1\n";
			if(/^0(MEPS|AEPS|AEPE|AEPR)(\d{8})(\d{8})(\d{9})(.*)(\d{3})(\d{2})(\d{4})(\s*)$/){
				print "TIPO: $1\n";
				print "ORIGEM: $2\n";
				print "DESTINO: $3\n";		
				print "MOEDA=$6\n";
				print "IVA=$7\n";			
				$data=$4;
				if($data =~m/(\d{4})(\d{2})(\d{2})\d/){ 
					$ano=$1; $mes=$2;$dia=$3;
					print "DATA: $data - Ano=$ano Mes=$mes Dia=$dia\n";				
				}

			}
		}
		if (/^9(.*)$/){
			print "TRAILER= $1\n";
		}
		if (/^2(.*)$/){
			#print "DETALHE= $1\n";
			if(/^2(\d{2})(\d{4})(\d{8})(\d{12})(\d{10})(.*)/){
				#print "TIPO: $1\n";
				#print "ORIGEM: $2\n";
				#print "DESTINO: $3\n";					
				$data=$4;
				if($data =~m/(\d{4})(\d{2})(\d{2})(\d{4})/){ 
					$ano=$1; $mes=$2;$dia=$3;$hora=$4;}
					print "DATA: $data - Dia=$dia Hora=$hora\n";				
			}
		}
	}	
	print "$f done.\n";
	close(FILE);
}




