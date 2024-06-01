#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;
uniform vec3 objectColor;
uniform vec3 lightColor;
// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
    FragColor = FragColor * (lightColor * objectColor, 1.0);
}