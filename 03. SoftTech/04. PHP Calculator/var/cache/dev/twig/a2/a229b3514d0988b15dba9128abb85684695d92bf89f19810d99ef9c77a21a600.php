<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_db279972afcdefc12b466f67c72c605deb165385b0f16d9ac80fdc01a08ee73e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_c918c91bfda8bcc6b6eda32d6fb9f11d2cd4a916bb8f47ade7725fb097b79a24 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c918c91bfda8bcc6b6eda32d6fb9f11d2cd4a916bb8f47ade7725fb097b79a24->enter($__internal_c918c91bfda8bcc6b6eda32d6fb9f11d2cd4a916bb8f47ade7725fb097b79a24_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_c918c91bfda8bcc6b6eda32d6fb9f11d2cd4a916bb8f47ade7725fb097b79a24->leave($__internal_c918c91bfda8bcc6b6eda32d6fb9f11d2cd4a916bb8f47ade7725fb097b79a24_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_367acd8f4989ae7bca0e4f3da8f61916557f806b12ae79a16dc5242af7174f9a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_367acd8f4989ae7bca0e4f3da8f61916557f806b12ae79a16dc5242af7174f9a->enter($__internal_367acd8f4989ae7bca0e4f3da8f61916557f806b12ae79a16dc5242af7174f9a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_367acd8f4989ae7bca0e4f3da8f61916557f806b12ae79a16dc5242af7174f9a->leave($__internal_367acd8f4989ae7bca0e4f3da8f61916557f806b12ae79a16dc5242af7174f9a_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_5d0d1ae9c2b7f3940a0fd8cf72cc4ca05be762647e378d277ca9b7c7a4206f13 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5d0d1ae9c2b7f3940a0fd8cf72cc4ca05be762647e378d277ca9b7c7a4206f13->enter($__internal_5d0d1ae9c2b7f3940a0fd8cf72cc4ca05be762647e378d277ca9b7c7a4206f13_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_5d0d1ae9c2b7f3940a0fd8cf72cc4ca05be762647e378d277ca9b7c7a4206f13->leave($__internal_5d0d1ae9c2b7f3940a0fd8cf72cc4ca05be762647e378d277ca9b7c7a4206f13_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_d7c10ccb237a4f2c5d6956574b1f93b59d83233be960bc7a0e934f5b88b99d0a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d7c10ccb237a4f2c5d6956574b1f93b59d83233be960bc7a0e934f5b88b99d0a->enter($__internal_d7c10ccb237a4f2c5d6956574b1f93b59d83233be960bc7a0e934f5b88b99d0a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_d7c10ccb237a4f2c5d6956574b1f93b59d83233be960bc7a0e934f5b88b99d0a->leave($__internal_d7c10ccb237a4f2c5d6956574b1f93b59d83233be960bc7a0e934f5b88b99d0a_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
