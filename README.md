# Fireboss
	Es un estimador de proyectos multi-idioma

# Idiomas soportados (Default en-US)
	en-US
	es-AR
	es-ES
	es-MX
	es-419

# Guardado de datos
	Lo realiza en formato XML

# 3 tipos de controles
	- OptionBool (Si es TRUE selecciona el ponderado, sinó no lo aplica)
		* Son preguntas de sí o no, ejemplo: ¿Requiere documentación? ¿Cubre carga FTP? ¿Necesita envio de mails?
	- Number (Multiplica el ponderado por el número que elijas)
		* Son preguntas de cantidad, ejemplo: ¿Con cuantas vistas interactúa? ¿Con cuantos navegadores interactua el robot? ¿Cantidad de reuniones?
	- Percent (Es un selector que va atado directo al ponderado de 0 a 500%)
		500% en un día de 8 horas, equivale a 5 días.
		* Casos muy extraños, ejemplo: Complejidad de pasos, complejidad de ambiente, complejidad de reglas de negocio, cosas un tanto relativas que pueden afectar al costo y duración de un proyecto. Otro valor que puede contemplar el percent es cuanto tiempo va a llevar la integración de módulos si se paraleliza un trabajo.

# ¿Cómo está compuesto?
	En la configuración se realiza la configuración de los templates, guardado y apertura, además de situar el About US.
	En la pantalla principal se cargan los templates generados y se puede guardar el estado en que se generó la estimacion, esto para no tener que volver a setear valores una vez aplicado el template.
	Tambien está la exportación que es un pdf con valores y un gantt.
	A hoy uso Business Entities y Business Objects, los entities son como los "models" y los objects como los "controllers"

# ¿Como funciona el ponderado?
	El ponderado funciona del siguiente modo:
	  Tenes un Base Hours, que vos le pones un valor (el que te sirva), yo uso base 8h. Estos ponderados son una medida de esfuerzo, cuanto tiempo en base 8 horas te lleva realizar determinada. 
	  Ese tiempo dividido 8 te daria un numero con decimales, eso último es el ponderado de esfuerzo.
	  Si el effort es "taken", lo pinta de rojo y marca como esfuerzo que  debes cobrar, si el effort es "saved", lo marca en verde y es un trabajo que te ahorra tiempo de trabajo, como componentes reusables, frameworks, etc...



# ¿En qué puedo ayudar?
	- Podes ponerte creativo no hay drama ni reglas al respecto
	- Se aceptan refactors
	- Es una licencia MIT podes modificarlo a tu gusto
	- El gantt me gustaría mejorarlo a veces falla
	- En cuanto a interfaz me parece que aún no es tan intuitivo y creo que puede mejorarse, pienso en mejorarle la experiencia de usuario
	- En el futuro pienso en integrarlo a microservicios
	- Si tenes un proyecto y tenes muchas vistas por estimar no vas a poder hacerlo a menos que setees un ponderado Percent y generes un aproximado. Hay que ver bien el tema "reglas" para hacer estimaciones más precisas.
	- Pienso que puede mejorar a nivel controles
  	- Cualquier cosa que pueda hacer la aplicación que haga la vida mas facil en gestion de proyectos, estimarlos y anticipar eventualidades será bienvenido.

