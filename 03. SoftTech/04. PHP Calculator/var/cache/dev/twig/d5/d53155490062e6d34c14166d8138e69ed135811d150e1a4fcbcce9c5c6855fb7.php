<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_89b1030ee638da06c96262149372f9a3b4e010f4d66c38439d3566a861c661d6 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_9b532ec88ce6c117f72382057b51f0a5bbc2b7072f687605278308f9d80e9b3d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9b532ec88ce6c117f72382057b51f0a5bbc2b7072f687605278308f9d80e9b3d->enter($__internal_9b532ec88ce6c117f72382057b51f0a5bbc2b7072f687605278308f9d80e9b3d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_9b532ec88ce6c117f72382057b51f0a5bbc2b7072f687605278308f9d80e9b3d->leave($__internal_9b532ec88ce6c117f72382057b51f0a5bbc2b7072f687605278308f9d80e9b3d_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_b1327ea71a0782e43ce548de5a7b3cbcbb6c0e59b49140765e839f85d794290d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b1327ea71a0782e43ce548de5a7b3cbcbb6c0e59b49140765e839f85d794290d->enter($__internal_b1327ea71a0782e43ce548de5a7b3cbcbb6c0e59b49140765e839f85d794290d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_b1327ea71a0782e43ce548de5a7b3cbcbb6c0e59b49140765e839f85d794290d->leave($__internal_b1327ea71a0782e43ce548de5a7b3cbcbb6c0e59b49140765e839f85d794290d_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_0c83399decbbbcbf7b5781b47bb2f3d59ddc055e9779cc4fc7ba64c73213b5e2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0c83399decbbbcbf7b5781b47bb2f3d59ddc055e9779cc4fc7ba64c73213b5e2->enter($__internal_0c83399decbbbcbf7b5781b47bb2f3d59ddc055e9779cc4fc7ba64c73213b5e2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_0c83399decbbbcbf7b5781b47bb2f3d59ddc055e9779cc4fc7ba64c73213b5e2->leave($__internal_0c83399decbbbcbf7b5781b47bb2f3d59ddc055e9779cc4fc7ba64c73213b5e2_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_cdd835619c0304a2213770b6f7ab3e0c61fb84d01ed28a86a2299cf18995ea58 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cdd835619c0304a2213770b6f7ab3e0c61fb84d01ed28a86a2299cf18995ea58->enter($__internal_cdd835619c0304a2213770b6f7ab3e0c61fb84d01ed28a86a2299cf18995ea58_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_cdd835619c0304a2213770b6f7ab3e0c61fb84d01ed28a86a2299cf18995ea58->leave($__internal_cdd835619c0304a2213770b6f7ab3e0c61fb84d01ed28a86a2299cf18995ea58_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
