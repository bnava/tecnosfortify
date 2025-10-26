// TriggerPlaceholderExamples.java
public class TriggerPlaceholderExamples {

    // 1) Field que recibe el placeholder (ejemplo para reglas que detectan FieldAccess en asignaciones)
    public static String placeholderField;

    public static void main(String[] args) {
        // 2) Literal de cadena simple (regla StructuralRule sobre StringLiteral)
        String s1 = "[_[Password]_]";
        System.out.println("Literal: " + s1);

        // 3) Asignación al campo (ejemplo para predicados que buscan AssignmentStatement lhs.location is fa)
        placeholderField = "[_[Password]_]"; // <- esta asignación debe ser detectada por la regla

        // 4) Concatenación / manipulación
        String part = "[_[Pass";
        String s2 = part + "word]_]";
        System.out.println("Concatenado: " + s2);

        // 5) En un array literal
        String[] arr = { "ok", "[_[Password]_]" };

        // 6) En un comentario (si también tienes regla para comentarios)
        // TODO: revisar credenciales [_[Password]_] -- comentario con placeholder

        // 7) Simulación de archivo properties cargado como literal (por si tu regla busca patrones en texto)
        String propertiesSample = "username=admin\npassword=[_[Password]_]\n";
        System.out.println(propertiesSample);

        // Evitar optimización de JIT para que los literales no se eliminen
        if (placeholderField.length() == 0) {
            System.out.println("nunca pasa");
        }
    }
}
