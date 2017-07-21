<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_567e338257b1897fb32e5b3d93b8bde5242356126f83cbc48c3ece079919a1a1 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_62c10efd992a66d509694a686a7e51b744586989a9b2d8e9511fcf6b918e7988 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_62c10efd992a66d509694a686a7e51b744586989a9b2d8e9511fcf6b918e7988->enter($__internal_62c10efd992a66d509694a686a7e51b744586989a9b2d8e9511fcf6b918e7988_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_62c10efd992a66d509694a686a7e51b744586989a9b2d8e9511fcf6b918e7988->leave($__internal_62c10efd992a66d509694a686a7e51b744586989a9b2d8e9511fcf6b918e7988_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_d0bed1babe18b4cb58ecfb5419f1a3559bc3efaa5fd6c1f01bb5218d45ebca93 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d0bed1babe18b4cb58ecfb5419f1a3559bc3efaa5fd6c1f01bb5218d45ebca93->enter($__internal_d0bed1babe18b4cb58ecfb5419f1a3559bc3efaa5fd6c1f01bb5218d45ebca93_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_d0bed1babe18b4cb58ecfb5419f1a3559bc3efaa5fd6c1f01bb5218d45ebca93->leave($__internal_d0bed1babe18b4cb58ecfb5419f1a3559bc3efaa5fd6c1f01bb5218d45ebca93_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_73f584fe7927bd2636dccda95b3bbb98bf839920db5e64f1c6010cc2f73a8349 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_73f584fe7927bd2636dccda95b3bbb98bf839920db5e64f1c6010cc2f73a8349->enter($__internal_73f584fe7927bd2636dccda95b3bbb98bf839920db5e64f1c6010cc2f73a8349_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_73f584fe7927bd2636dccda95b3bbb98bf839920db5e64f1c6010cc2f73a8349->leave($__internal_73f584fe7927bd2636dccda95b3bbb98bf839920db5e64f1c6010cc2f73a8349_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_b241e82ab4112ea6c64d201922a02712dd0e84988a632bd1ccf7077b678e1b75 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b241e82ab4112ea6c64d201922a02712dd0e84988a632bd1ccf7077b678e1b75->enter($__internal_b241e82ab4112ea6c64d201922a02712dd0e84988a632bd1ccf7077b678e1b75_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_b241e82ab4112ea6c64d201922a02712dd0e84988a632bd1ccf7077b678e1b75->leave($__internal_b241e82ab4112ea6c64d201922a02712dd0e84988a632bd1ccf7077b678e1b75_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
