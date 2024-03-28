# raycast_Milho
Cena no Unity feita para aplicar os conceitos de Raycast, Prefab e Destroy

# Criador
 
- Robert Caio Gomes Mota

# Cena
- Link do Drive com o Projeto: https://drive.google.com/file/d/1bWQwysYlqT5s8QSj0CAu97pmZ5zCdL0-/view?usp=sharing

# Assets usados
- Asset da plantação de Milho
 ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/7997e011-5542-4f51-ae50-26b5148f01de)

- Asset da torre d'agua no canto
![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/6dd0f69c-4bc4-43d2-97c4-f423695d499a)

- Asset do Milho que dança
   ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/89123031-2b3d-41d4-afd2-19de56e7047b)

- Asset para a casa
  ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/a04e2d4b-f248-45b1-a4bf-53c36821a7dc)

- Asset para as naves de ataque
 ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/0d9a5ebe-6f7c-4689-a87f-cc21b9e501dd)

- Asset da grande igreja
  ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/34089e97-3293-4701-b7bd-1c1fb8502a23)

# Codigos

- Codigo usado na camera
  
 ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/c317ba13-98d9-4a89-b5e1-f82ec6e4cc40)

- Nele declaramos a rotação de cada direção pelos controles do mouseX e Y. Além também da sensibilidade na vertical e horizonatal, e o minimo e o maximo em que o eixo Y pode chegar.
 Cursor.lockState - usado para travar o cursor do mouse no meio, o que também o deixa invisivel.

 ![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/4edf1bd0-63d7-4050-a51d-a84b8f06538c)

 - Nessa parte codigo é criado o sistema da rotação, a partir de caso o mouse seja rotacionado no eixo X ele irá mutiplicar o valor da rotação e a sua sensibilidade. A mesma logica é usada abaixo para o eixo Y e abaixo dele o que ele fará caso o mouse seja movido de uma forma angular, ou seja, para os dois eixos.

- Codigo da adição dos milhos
  
![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/f80ac6cb-54a0-4daf-8741-c8ca3d2eb8ef)

- É um codigo simples com a função For para multiplicar o Prefab de Corn_plant (milho) para a direção sugerida determinada vezes.

- Codigo Raycast

![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/69fa8101-9436-4e51-baa6-ee41aaf9304c)

- O codigo mais importante, no seu começo temos as delcarações dos aributos e metodos, como Ray, RaycatsHit, Vector3, Color, public Camera.
- No start está chamando um metodo de gerar o alvo, neste caso as naves]

![image](https://github.com/Rob3rt2/raycast_Milho/assets/127865166/0dfa1be7-befb-4946-b924-5d23cb8aa64c)

- Nesta parte do codigo, localizado no void update temos o lançamento do ray determinada pelo clique do botão direito do mouse e indo na direção do mouse.
- No void lancar, temos toda a parte de Debug do codigo, além também da parte de identificação do alvo atingido e destruição dele, dizendo a direção que foi atingido e a posição e também caso não tenha atingido dará como "target missed" (alvo perdido).
- Por fim do codigo temos a função de gerar objeto que declara um raio em que eles irão aparecer e seu intervalo de tempo, neste caso 1 segundo.

# Gameplay imagens








