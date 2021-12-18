#----------------------------------------------------------------------------
# Vida Económica - trataACaracteres
# Lufer-Sidereus
# Aplica filtros aos HTML gerados a partir dos RTF
#----------------------------------------------------------------------------

if (length($ARGV[0])==0){
	print "Falta a PATH da directoria ....\n";
	return;
}

#----definir Paths e configurações
$homePath="./$ARGV[0]";

$ok=0;
opendir(DIR, "$homePath") || die "can't opendir $homePath: $!";
#@files = grep { /(\.html)/ && -f "$homePath/$_" } readdir(DIR);
@files = grep {/(\.html)/} readdir(DIR);
closedir DIR;

while (<@files>)
{
	$f=$_;
	open (FOUT,"> $homePath/$f.new") || warn "Nao consegui criar $f.new\n";
	open (FILE,"$homePath/$f") || warn "File $f inexistente...\n";;


	$ok=0;
	while (<FILE>) {
		$ok=1;
		#limpar lixo do RTFtoHTML
		if (/<HTML><HEAD>/){
			s/<HTML>(.*)//ig;
			$head=1;
		}
		elsif (/<TITLE>/){
			if (/<HEAD>/){$head=0;}
			s/<TITLE>(.*)<\/TITLE>(.*)//ig;
		}
		elsif (/<BODY/){
			s/<BODY(.*)//g;		#eliminar o BODY colocado pelo rtftohtm
		}
		elsif ($head==1){s/(.*)//g;$head=0;}
		else {
			s/<H1>//g;
			s/(.*)<\/H1>//g;
			s/<\/HEAD>//g;
		}
				

		#Tratar acentuação mal convertida
		s/\[Otilde\]/\&Otilde\;/g;			#Ex: Ó
		s/\[Atilde\]/\&Atilde\;/g;			#Ex: Á

		#Palavras mal compostas
		s/([A-Z])á([A-Z])/$1\&Aacute\;$2/g;		#Ex: TáR
		s/([A-Z])\&aacute\;([A-Z])/$1\&Aacute\;$2/g;	

		s/([A-Z]*)ú([A-Z])/$1\&Uacute\;$2/g;		#Ex: úNico
		s/([A-Z]*)\&uacute\;([A-Z])/$1\&Uacute\;$2/g;	#Ex: Número

		s/([A-Z])ó([A-Z])/$1\&Oacute\;$2/g;		#Ex: TóR
		s/([A-Z])\&oacute\;([A-Z])/$1\&Oacute\;$2/g;

		s/([A-Z])é([A-Z])/$1\&Eacute\;$2/g;		#Ex: FéRIAS
		s/([A-Z])\&eacute\;([A-Z])/$1\&Eacute\;$2/g;

		s/([A-Z])í([A-Z])/$1\&Iacute\;$2/g;		#Ex: INíCIO
		s/([A-Z])\&iacute\;([A-Z])/$1\&Iacute\;$2/g;	#

		
		s/([A-Z])ç([A-Z])/$1\&Ccedil\;$2/g;		#Ex: BALANçO
		s/([A-Z])\&ccedil\;([A-Z])/$1\&Ccedil\;$2/g;

		s/([A-Z])ã([A-Z])/$1\&Atilde\;$2/g;		#Ex: PROVISãO
		s/([A-Z])\&atilde\;([A-Z])/$1\&Atilde\;$2/g;
		

		s/([A-Z])çã([A-Z])/$1\&Ccedil\;\&Atilde\;$2/g;	#Ex: ACçãO
		s/([A-Z])\&ccedil\;&atilde\;([A-Z])/$1\&Ccedil\;\&Atilde\;$2/g;	#Ex: ACçãO

		s/([A-Z])çõ([A-Z])/$1\&Ccedil\;\&Otilde\;$2/g;	#Ex: CONTRIBUIçõES
		s/([A-Z])\&ccedil\;&otilde\;([A-Z])/$1\&Ccedil\;\&Otilde\;$2/g;	

		s/([A-Z])ê([A-Z])/$1\&Ecirc\;$2/g;		#Ex: CONCORRêNCIA
		s/([A-Z])\&ecirc\;([A-Z])/$1\&Ecirc\;$2/g;

		s/([A-Z])õ([A-Z])/$1\&Otilde\;$2/g;		#Ex: REGIõES
		s/([A-Z])\&otilde\;([A-Z])/$1\&Otilde\;$2/g;

		s/([A-Z]*)à([A-Z])/$1\&Agrave\;$2/g;		#Ex: àS vezes
		s/([A-Z]*)\&agrave\;([A-Z])/$1\&Agrave\;$2/g;


		print FOUT $_;
	}

	close (FOUT);
	close (FILE);
	exec "del $f";
	rename ("$homePath/$f.new", "$homePath/$f") || warn $!;

	if ($ok==1) {print "File= $homePath/$f .. done.\n";}
}
