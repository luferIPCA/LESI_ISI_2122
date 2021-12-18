1	#!d:\perl\bin\perl -w
2	# --------------------------------------------------------------------
3	# Perl by example
4	# exemplos de Perl (1)
5	# by lufer
6	# Disciplina: ISI
7	# --------------------------------------------------------------------
8	
9	
10	print "doing exe2.pl\n";
11	do 'exe2.pl';
12	print "\n";
13	
14	#-----------------------------------
15	#Variáveis
16	$x = 12;
17	$y = $x+1;
18	print "X=$y\n";
19	
20	$str ="Viva o Benfica";
21	print "$str \n";
22	
23	#-----------------------------------
24	#Arrays 
25	@arr = (1,"O Glorioso",3,"Benfica");
26	print "$arr[1]=$arr[3]\n";
27	
28	$arr[1]="O Maior";
29	print "$arr[1]=$arr[3]\n";
30	
31	#-------
32	
33	@letras=('a'..'z');
34	$x=$letras[7];
35	print "\$x=$x\n";
36	
37	#-------
38	($x,$y)=@letras[3,5];
39	print "\$x=$x \$y=$y\n";
40	
41	@aux=@letras[2,5,13];
42	print "Length de aux=".@aux."\n";	#length de um array é dado pelo nome do array: @arr
43	print "Ultima posicao de aux=".$#aux."\n";	#última posição do array= @arr-1
44	
45	@chars=(0..9,'a'..'z');
46	print sort(@chars);print "\n";
47	print sort({$b cmp $a} @chars);
48	#-----------------------------------
49	#Arrays associativos (Hash)
50	print "\n";
51	
52	%meses=(
53		'jan'=>1,
54		'fev'=>2,
55		);
56	print $meses{'jan'};
57	print "\n";
58	
59	#-----------------------------------
60	@semana{'jan','fev','mar'}=(1,2,3);
61	
62	print $semana{'jan'};
63	print "\n";
64	#-----------------------------------
65	%meses=(
66		1=>'jan',
67		2=>'fev',
68		);
69	print "Mes 2=". $meses{2};
70	print "\n";
71	#----done;
