<?php

/* base.html.twig */
class __TwigTemplate_8bb92bcb5f66c9642672c0e7f5c5dfb3d8e9f08439dba755fe075e83bedfc6d9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_df72788b8aaeab252f01444624f8a2c88e4bf4a51adab80d35138fdee130f592 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_df72788b8aaeab252f01444624f8a2c88e4bf4a51adab80d35138fdee130f592->enter($__internal_df72788b8aaeab252f01444624f8a2c88e4bf4a51adab80d35138fdee130f592_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_df72788b8aaeab252f01444624f8a2c88e4bf4a51adab80d35138fdee130f592->leave($__internal_df72788b8aaeab252f01444624f8a2c88e4bf4a51adab80d35138fdee130f592_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_62b6ac8a7d1a186e1c0c83354e0eb2a5574d48aad4b4d68efdfff9c15f9c7a39 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_62b6ac8a7d1a186e1c0c83354e0eb2a5574d48aad4b4d68efdfff9c15f9c7a39->enter($__internal_62b6ac8a7d1a186e1c0c83354e0eb2a5574d48aad4b4d68efdfff9c15f9c7a39_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_62b6ac8a7d1a186e1c0c83354e0eb2a5574d48aad4b4d68efdfff9c15f9c7a39->leave($__internal_62b6ac8a7d1a186e1c0c83354e0eb2a5574d48aad4b4d68efdfff9c15f9c7a39_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_1a6646b2843f4d56d6189725db6720e925b3f08598a89f344514de78e3f55310 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1a6646b2843f4d56d6189725db6720e925b3f08598a89f344514de78e3f55310->enter($__internal_1a6646b2843f4d56d6189725db6720e925b3f08598a89f344514de78e3f55310_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_1a6646b2843f4d56d6189725db6720e925b3f08598a89f344514de78e3f55310->leave($__internal_1a6646b2843f4d56d6189725db6720e925b3f08598a89f344514de78e3f55310_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_9e0888a815232b26f726ed6499d6b45309d33b5eae83235d9b3f7a5bac36ffce = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9e0888a815232b26f726ed6499d6b45309d33b5eae83235d9b3f7a5bac36ffce->enter($__internal_9e0888a815232b26f726ed6499d6b45309d33b5eae83235d9b3f7a5bac36ffce_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_9e0888a815232b26f726ed6499d6b45309d33b5eae83235d9b3f7a5bac36ffce->leave($__internal_9e0888a815232b26f726ed6499d6b45309d33b5eae83235d9b3f7a5bac36ffce_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_24c537e7d8a599ddf57229423f52c419a1f8cca0b09171174cd13dd13b7fa7e6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_24c537e7d8a599ddf57229423f52c419a1f8cca0b09171174cd13dd13b7fa7e6->enter($__internal_24c537e7d8a599ddf57229423f52c419a1f8cca0b09171174cd13dd13b7fa7e6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_24c537e7d8a599ddf57229423f52c419a1f8cca0b09171174cd13dd13b7fa7e6->leave($__internal_24c537e7d8a599ddf57229423f52c419a1f8cca0b09171174cd13dd13b7fa7e6_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_4bfd64710169ccb72fa720063b1ce92d2e42888876fa72cad305953a4785f4e0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4bfd64710169ccb72fa720063b1ce92d2e42888876fa72cad305953a4785f4e0->enter($__internal_4bfd64710169ccb72fa720063b1ce92d2e42888876fa72cad305953a4785f4e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_4bfd64710169ccb72fa720063b1ce92d2e42888876fa72cad305953a4785f4e0->leave($__internal_4bfd64710169ccb72fa720063b1ce92d2e42888876fa72cad305953a4785f4e0_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_85dc25357f629f820c8ec9cbaaf848de936a41c4a86c4382be0f94b0aaffbbcd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_85dc25357f629f820c8ec9cbaaf848de936a41c4a86c4382be0f94b0aaffbbcd->enter($__internal_85dc25357f629f820c8ec9cbaaf848de936a41c4a86c4382be0f94b0aaffbbcd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_85dc25357f629f820c8ec9cbaaf848de936a41c4a86c4382be0f94b0aaffbbcd->leave($__internal_85dc25357f629f820c8ec9cbaaf848de936a41c4a86c4382be0f94b0aaffbbcd_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_568455d678655f8b4716f99b9d790c23e2297d28ac1b43181fd33495d4692426 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_568455d678655f8b4716f99b9d790c23e2297d28ac1b43181fd33495d4692426->enter($__internal_568455d678655f8b4716f99b9d790c23e2297d28ac1b43181fd33495d4692426_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_568455d678655f8b4716f99b9d790c23e2297d28ac1b43181fd33495d4692426->leave($__internal_568455d678655f8b4716f99b9d790c23e2297d28ac1b43181fd33495d4692426_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
